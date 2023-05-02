using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SORA_Class
{
    internal class VerifiedAccount
    {
        private string id;
        private string name;
        private DateTime creationTime;
        private AccountCategory category;
        private Admin verificator;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public DateTime CreationTime { get => creationTime; set => creationTime = value; }
        internal AccountCategory Category { get => category; set => category = value; }
        internal Admin Verificator { get => verificator; set => verificator = value; }
        
        public VerifiedAccount(string id, string name, DateTime creationTime, AccountCategory category, Admin verificator)
        {
            Id = id;
            Name = name;
            CreationTime = creationTime;
            Category = category;
            Verificator = verificator;
        }

        public VerifiedAccount()
        {
            Id = "";
            Name = "";
            CreationTime = DateTime.Now;
            Category = new AccountCategory();
            Verificator = new Admin();
        }

        public static bool AddVerif(VerifiedAccount verifiedAccount)
        {
            #region SQL Parameter
            var idParam = new MySqlParameter("@id", MySqlDbType.VarChar, 45)
            {
                Direction = System.Data.ParameterDirection.Input,
                Value = verifiedAccount.Id
            };

            var nameParam = new MySqlParameter("@merchant_name", MySqlDbType.VarChar, 45)
            {
                Direction = System.Data.ParameterDirection.Input, 
                Value = verifiedAccount.Name
            };

            #endregion

            string sql = "INSERT INTO tAdmins (id, merchant_name) VALUES (@id, @merchant_name);";

            Connection connection = new Connection();

            if (MySqlHelper.ExecuteNonQuery(connection.DbConnection, sql, idParam, nameParam) > 0)
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
