using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SORA_Class
{
    public class Transaction
    {
        int id;
        Customer sender;
        Customer recepient;
        DateTime transactionDate;
        double nominal;
        bool completed;

        public int Id { get => id; set => id = value; }
        public Customer Sender { get => sender; set => sender = value; }
        public Customer Recepient { get => recepient; set => recepient = value; }
        public DateTime TransactionDate { get => transactionDate; set => transactionDate = value; }
        public double Nominal { get => nominal; set => nominal = value; }
        public bool Completed { get => completed; set => completed = value; }

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
    }
}
