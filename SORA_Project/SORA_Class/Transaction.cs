using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Text.Unicode;
using System.Threading.Tasks;
using System.Transactions;

namespace SORA_Class
{
    public class Transaction
    {
        int id;
        Customer sender;
        Customer recipient;
        DateTime transactionDate;
        decimal nominal;
        bool completed;

        public int Id { get => id; set => id = value; }
        public Customer Sender { get => sender; set => sender = value; }
        public Customer Recipient { get => recipient; set => recipient = value; }
        public DateTime TransactionDate { get => transactionDate; set => transactionDate = value; }
        public decimal Nominal { get => nominal; set => nominal = value; }
        public bool Completed { get => completed; set => completed = value; }
       

        public Transaction(int id, Customer sender, Customer recipient, DateTime transactionDate,
            decimal nominal, bool completed)
        {
            Id = id;
            Sender = sender;
            Recipient = recipient;
            TransactionDate = transactionDate;
            Nominal = nominal;
            Completed = completed;
        }

        public Transaction()
        {
            Id = 0;
            Sender = new Customer();
            Recipient = new Customer();
            TransactionDate = DateTime.Now;
            Nominal = 0;
            Completed = true;
        }

        /// <summary>
        /// Inserts a transaction to the database
        /// </summary>
        /// <param name="transaction">Transaction object to be inserted. The customer objects need atleast
        /// their ID set.</param>
        /// <returns>If true, means that the insert is successfu. If false, then it has failed.</returns>
        public static bool Add(Transaction transaction)
        {
            var utf16 = new UnicodeEncoding();

            byte[] recipientPublicKey = Customer.GetRSAPublicKey(transaction.Recipient.Id);
            int bytesRead = 0;

            //RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
            //RSA.ImportRSAPublicKey(recipientPublicKey, out bytesRead);

            byte[] transactionNominalBytes = utf16.GetBytes(transaction.Nominal.ToString());

            //Encrypt the nominal with RSA.
            byte[] eTransactionNominal = RSA.RSAEncrypt(transactionNominalBytes, recipientPublicKey);

            const string sql = "INSERT INTO tTransaction_Account-Account(senderID, recipientID, transaction_nominal," +
                "transaction_date, completed) " +
                "VALUES(@senderID, @recipientID, @transaction_nominal, @transaction_date, @completed);";

            int transactionCompletedInt = 0;
            if (transaction.Completed)
            {
                transactionCompletedInt = 1;
            }

            #region SQL Parameters
            var senderIDParam = new MySqlParameter("@senderID", MySqlDbType.VarChar, 45)
            {
                Direction = ParameterDirection.Input,
                Value = transaction.Sender.Id
            };

            var recipientIDParam = new MySqlParameter("@recipientID", MySqlDbType.VarChar, 45)
            {
                Direction = ParameterDirection.Input,
                Value = transaction.Recipient.Id
            };

            var transactionNominalParam = new MySqlParameter("@transaction_nominal", MySqlDbType.VarBinary)
            {
                Direction = ParameterDirection.Input,
                Size = eTransactionNominal.Length,
                Value = eTransactionNominal
            };

            var transactionDateParam = new MySqlParameter("@transaction_date", MySqlDbType.DateTime)
            {
                Direction = ParameterDirection.Input,
                Value = transaction.TransactionDate.ToString("yyyy-MM-dd hh:mm:ss")
            };

            var completedParam = new MySqlParameter("@completed", MySqlDbType.Int64)
            {
                Direction = ParameterDirection.Input,
                Value = transactionCompletedInt
            };
            #endregion

            Connection connection = new Connection();


            if (MySqlHelper.ExecuteNonQuery(connection.DbConnection, sql, senderIDParam, recipientIDParam, 
                transactionNominalParam, transactionDateParam, completedParam) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Read user transactions query:
        //SELECT*
        //FROM tTransaction_Account-Account
        //WHERE senderID = @idcustomer OR recipientID = @idcustomer
        //ORDER BY transaction_date DESC;

        /// <summary>
        /// Reads all user Transactions history both Sending and Receiving
        /// </summary>
        /// <param name="customerId">Customer's ID</param>
        /// <param name="email">Customer's Email address</param>
        /// <param name="password">Customer's password in plaintext</param>
        /// <returns>All user Transactions history</returns>
        public static List<Transaction> ReadTransactions(string customerId, string email, string password)
        {
            const string sql = "//SELECT* FROM tTransaction_Account-Account " +
                "WHERE senderID = @idcustomer OR recipientID = @idcustomer ORDER BY transaction_date DESC;";

            var utf16 = new UnicodeEncoding();

            byte[] privateKey = Customer.GetRSAPrivateKey(email, password);

            var recipientIDParam = new MySqlParameter("@idcustomer", MySqlDbType.VarChar, 45)
            {
                Direction = ParameterDirection.Input,
                Value = customerId
            };

            Connection connection = new Connection();
            MySqlDataReader result = MySqlHelper.ExecuteReader(connection.DbConnection, sql, recipientIDParam);

            List<Transaction> transactionList = new List<Transaction>();
            while (result.Read() == true)
            {
                Transaction transaction = new Transaction();
                transaction.Sender.Id = result.GetValue(0).ToString();
                transaction.Recipient.Id = result.GetValue(1).ToString();
                transaction.Sender.Email = Customer.SearchByID(transaction.Sender.Id);
                transaction.Recipient.Email = Customer.SearchByID(transaction.Recipient.Id);

                byte[] eTransactionNominal = (byte[])(result["transaction_nominal"]);
                byte[] transactionNominalBytes = RSA.RSADecrypt(eTransactionNominal, privateKey);
                transaction.Nominal = decimal.Parse(utf16.GetString(transactionNominalBytes));

                transaction.TransactionDate = DateTime.Parse(result.GetValue(3).ToString());

                int completedInt = int.Parse(result.GetValue(4).ToString());
                if (completedInt == 0)
                {
                    transaction.Completed = false;
                }
                else
                {
                    transaction.Completed = true;
                }

                transactionList.Add(transaction);
            }
            return transactionList;
        }

        public static bool CompleteTransaction(string transactionID, Connection connection)
        {
            const string sql = "UPDATE tTransaction_Account-Account SET completed = 1 " +
                "WHERE transactionID = @transactionID";

            var idParam = new MySqlParameter("@transactionID", MySqlDbType.Int64)
            {
                Direction = System.Data.ParameterDirection.Input,
                Value = transactionID
            };

            if (MySqlHelper.ExecuteNonQuery(connection.DbConnection, sql, idParam) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool ProcessTransactions(string customerId, string email, string password)
        {
            const string sql = "SELECT * FROM tTransaction_Account-Account WHERE recipientID = @recipientID " +
                "AND completed = 0"; 
            //Reads all transactions where the user is the recipient
            //and the transaction is not yet processed or completed

            var utf16 = new UnicodeEncoding();

            byte[] privateKey = Customer.GetRSAPrivateKey(email, password);

            var recipientIDParam = new MySqlParameter("@recipientID", MySqlDbType.VarChar, 45)
            {
                Direction = ParameterDirection.Input,
                Value = customerId
            };

            //Encrypt the nominal with RSA.
            //byte[] eTransactionNominal = RSA.RSADecrypt(transactionNominalBytes, recipientPublicKey);

            Connection connection = new Connection();
            MySqlDataReader result = MySqlHelper.ExecuteReader(connection.DbConnection, sql, recipientIDParam);

            List<Transaction> transactionList = new List<Transaction>();
            while (result.Read() == true)
            {
                Transaction transaction = new Transaction();
                transaction.Sender.Id = result.GetValue(0).ToString();
                transaction.Recipient.Id = result.GetValue(1).ToString();
                transaction.Sender.Email = Customer.SearchByID(transaction.Sender.Id);
                transaction.Recipient.Email = Customer.SearchByID(transaction.Recipient.Id);

                byte[] eTransactionNominal = (byte[])(result["transaction_nominal"]);
                byte[] transactionNominalBytes = RSA.RSADecrypt(eTransactionNominal, privateKey);
                transaction.Nominal = decimal.Parse(utf16.GetString(transactionNominalBytes));

                transaction.TransactionDate = DateTime.Parse(result.GetValue(3).ToString());

                int completedInt = int.Parse(result.GetValue(4).ToString());
                if (completedInt == 0)
                {
                    transaction.Completed = false;
                }
                else
                {
                    transaction.Completed = true;
                }

                transactionList.Add(transaction);
            }
            //return transactionList;

            Customer customer = Customer.ReadData(email, password);
            //List<Transaction> unprocessedTransactions = Transaction.ReadProcessTransactions(customer.Id,
            //    email, password);

 
            foreach (Transaction transaction in transactionList)
            {
                customer.Balance += transaction.Nominal;
            }

            using(TransactionScope transactionScope = new TransactionScope())
            {
                try
                {
                    string sqlUpdateTransaction = "UPDATE tTransaction_Account-Account SET completed = 1 WHERE completed = 0";

                    if (MySqlHelper.ExecuteNonQuery(connection.DbConnection, sqlUpdateTransaction) > 0)
                    {
                        if(Customer.UpdateBalance(customer, password, connection) == true)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }

                    //Returns true anyway because no transactions are modified
                    //This route means that the customer don't have unprocessed transactions
                    //Therefore doesn't need to have their balance updated.
                    return true;
                }
                catch (Exception ex)
                {
                    transactionScope.Dispose();
                    return false;
                    throw new Exception("Transaction failed!: " + ex.Message);
                }
            }
        }
    }
}
