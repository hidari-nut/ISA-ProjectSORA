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
        string senderID;
        string recipientID;
        DateTime transactionDate;
        decimal nominal;
        bool completed;

        public int Id { get => id; set => id = value; }
        public string SenderID { get => senderID; set => senderID = value; }
        public string RecipientID { get => recipientID; set => recipientID = value; }
        public DateTime TransactionDate { get => transactionDate; set => transactionDate = value; }
        public decimal Nominal { get => nominal; set => nominal = value; }
        public bool Completed { get => completed; set => completed = value; }
       

        public Transaction(int id, string senderID, string recipientID, DateTime transactionDate,
            decimal nominal, bool completed)
        {
            Id = id;
            SenderID = senderID;
            RecipientID = recipientID;
            TransactionDate = transactionDate;
            Nominal = nominal;
            Completed = completed;
        }

        public Transaction()
        {
            Id = 0;
            SenderID = "";
            RecipientID = "";
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
        public static bool Add(Transaction transaction, string senderPlainPassword)
        {
            var utf16 = new UnicodeEncoding();

            byte[] recipientPublicKey = Customer.GetRSAPublicKey(transaction.RecipientID);
            int bytesRead = 0;

            //RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
            //RSA.ImportRSAPublicKey(recipientPublicKey, out bytesRead);

            byte[] transactionNominalBytes = utf16.GetBytes(transaction.Nominal.ToString());

            //Encrypt the nominal with RSA.
            byte[] eTransactionNominal = RSA.RSAEncrypt(transactionNominalBytes, recipientPublicKey);

            const string sql = "INSERT INTO tTransaction_Account(transactionID, senderID, recipientID, transaction_nominal," +
                "transaction_date, completed) " +
                "VALUES(@transactionID, @senderID, @recipientID, @transaction_nominal, @transaction_date, @completed);";

            int transactionCompletedInt = 0;
            if (transaction.Completed)
            {
                transactionCompletedInt = 1;
            }

            #region SQL Parameters
            var transactionIdParam = new MySqlParameter("@transactionID", MySqlDbType.VarChar, 45)
            {
                Direction = ParameterDirection.Input,
                Value = transaction.Id
            };
            var senderIDParam = new MySqlParameter("@senderID", MySqlDbType.VarChar, 45)
            {
                Direction = ParameterDirection.Input,
                Value = transaction.SenderID
            };

            var recipientIDParam = new MySqlParameter("@recipientID", MySqlDbType.VarChar, 45)
            {
                Direction = ParameterDirection.Input,
                Value = transaction.RecipientID
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

            string senderEmail = Customer.SearchByID(transaction.SenderID);
            Customer senderUser = Customer.ReadData(senderEmail, senderPlainPassword);

            if (senderUser.Balance >= transaction.Nominal)
            {
                senderUser.Balance -= transaction.Nominal;

                Customer.UpdateBalance(senderUser, senderPlainPassword);

                if (MySqlHelper.ExecuteNonQuery(connection.DbConnection, sql, transactionIdParam,senderIDParam, recipientIDParam,
                transactionNominalParam, transactionDateParam, completedParam) > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                //Sender's balance is not enough.
                return false;
            }


            //using(TransactionScope transactionScope = new TransactionScope())
            //{
            //    try
            //    {
            //        Connection connection = new Connection();

            //        string senderEmail = Customer.SearchByID(transaction.SenderID, connection);
            //        Customer senderUser = Customer.ReadData(senderEmail, senderPlainPassword, connection);

            //        if(senderUser.Balance >= transaction.Nominal)
            //        {
            //            senderUser.Balance -= transaction.Nominal;

            //            Customer.UpdateBalance(senderUser, senderPlainPassword, connection);

            //            if (MySqlHelper.ExecuteNonQuery(connection.DbConnection, sql, senderIDParam, recipientIDParam,
            //            transactionNominalParam, transactionDateParam, completedParam) > 0)
            //            {
            //                transactionScope.Complete();
            //                return true;
            //            }
            //            else
            //            {
            //                transactionScope.Dispose();
            //                return false;
            //            }
            //        }
            //        else
            //        {
            //            //Sender's balance is not enough.
            //            transactionScope.Dispose();
            //            return false;
            //        }

            //    }
            //    catch (Exception ex)
            //    {
            //        transactionScope.Dispose();
            //        throw new Exception("Transaction failed!: " + ex.Message);
            //        return false;

            //    }
            //}
        }

        //Read user transactions query:
        //SELECT*
        //FROM tTransaction_Account
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
            const string sql = "//SELECT* FROM tTransaction_Account " +
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
                transaction.SenderID = result.GetValue(0).ToString();
                transaction.RecipientID = result.GetValue(1).ToString();
                //transaction.Sender.Email = Customer.SearchByID(transaction.Sender.Id);
                //transaction.Recipient.Email = Customer.SearchByID(transaction.Recipient.Id);

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

        /// <summary>
        /// Processes all customer's unprocessed transactions, adding nominal to customer's balance
        /// </summary>
        /// <param name="customerId">Designated customer's id</param>
        /// <param name="email">Designated customer's email</param>
        /// <param name="password">Customer's plaintext password</param>
        /// <returns>If the process is successful</returns>
        /// <exception cref="Exception"></exception>
        public static bool ProcessTransactions(string customerId, string email, string password)
        {
            const string sql = "SELECT * FROM tTransaction_Account WHERE recipientID = @recipientID " +
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

            Connection connection = new Connection();
            MySqlDataReader result = MySqlHelper.ExecuteReader(connection.DbConnection, sql, recipientIDParam);

            List<Transaction> transactionList = new List<Transaction>();
            while (result.Read() == true)
            {
                Transaction transaction = new Transaction();
                transaction.SenderID = result.GetValue(0).ToString();
                transaction.RecipientID = result.GetValue(1).ToString();
                //transaction.Sender.Email = Customer.SearchByID(transaction.Sender.Id);
                //transaction.Recipient.Email = Customer.SearchByID(transaction.Recipient.Id);

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
 
            foreach (Transaction transaction in transactionList)
            {
                customer.Balance += transaction.Nominal;
            }

            using(TransactionScope transactionScope = new TransactionScope())
            {
                try
                {
                    string sqlUpdateTransaction = "UPDATE tTransaction_Account SET completed = 1 WHERE completed = 0";

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
