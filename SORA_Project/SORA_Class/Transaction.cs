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
        Customer recepient;
        DateTime transactionDate;
        decimal nominal;
        bool completed;

        public int Id { get => id; set => id = value; }
        public Customer Sender { get => sender; set => sender = value; }
        public Customer Recepient { get => recepient; set => recepient = value; }
        public DateTime TransactionDate { get => transactionDate; set => transactionDate = value; }
        public decimal Nominal { get => nominal; set => nominal = value; }
        public bool Completed { get => completed; set => completed = value; }

        public Transaction(int id, Customer sender, Customer recepient, DateTime transactionDate,
            decimal nominal, bool completed)
        {
            Id = id;
            Sender = sender;
            Recepient = recepient;
            TransactionDate = transactionDate;
            Nominal = nominal;
            Completed = completed;
        }

        public Transaction()
        {
            Id = 0;
            Sender = new Customer();
            Recepient = new Customer();
            TransactionDate = DateTime.Now;
            Nominal = 0;
            Completed = true;
        }

        public static bool Add(Transaction transaction)
        {
            var utf16 = new UnicodeEncoding();

            byte[] recipientPublicKey = Customer.GetRSAPublicKey(transaction.Recepient.Email);
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
                Value = transaction.Recepient.Id
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
        /// Reads all incoming transactions that aren't processed yet
        /// </summary>
        /// <param name="customerId">Customer's ID</param>
        /// <returns>A list of unprocessed incoming transactions</returns>
        public static List<Transaction> ReadProcessTransactions(string customerId, string email, string password)
        {
            const string sql = "SELECT * FROM tTransaction_Account-Account WHERE recipientID = @recipientID";

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
                //transaction.Sender = Customer.FINDUSERFROMID(result.GetValue(0).ToString());
                //transaction.Recepient = Customer.FINDUSERFROMID(result.GetValue(1).ToString());

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
    }
}
