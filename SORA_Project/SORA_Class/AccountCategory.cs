using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System.Web.Helpers;
using System.Security.Cryptography;
using System.Data;
using Org.BouncyCastle.Crypto.Engines;
using System.Text.Unicode;
using Org.BouncyCastle.Ocsp;

namespace SORA_Class
{
    internal class AccountCategory
    {
        private string id;
        private string name;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }

        public AccountCategory(string id, string name)
        {
            Id = id;
            Name = name;
        }

        public AccountCategory()
        {
            Id = "";
            Name = "";
        }

        public static bool AddAccountCategory(AccountCategory accountCategory)
        {
            #region SQL PARAMETER
            var idParam = new MySqlParameter("@AccountCategory_id", MySqlDbType.Int64)
            {
                Direction = System.Data.ParameterDirection.Input,
                Value = accountCategory.Id
            };

            var nameParam = new MySqlParameter("@name", MySqlDbType.VarChar, 45)
            {
                Direction = System.Data.ParameterDirection.Input,
                Value = accountCategory.name
            };
            #endregion
            string sql = "INSERT INTO tAccount_Categories (AccountCategory_id, AccountCategory_name) VALUES " + "(@AccountCategory_id, @name)";

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
        public static bool UpdateAccountCategory(AccountCategory accountCategory)
        {
            #region SQL Parameter
            var idParam = new MySqlParameter("@accountCategory_id", MySqlDbType.Int64)
            {
                Direction = System.Data.ParameterDirection.Input,
                Value = accountCategory.Id
            };

            var nameParam = new MySqlParameter("@name", MySqlDbType.VarChar, 45)
            {
                Direction = System.Data.ParameterDirection.Input,
                Value = accountCategory.name
            };
            #endregion

            string sql = "UPDATE tAccount_Categories SET name = @name = WHERE accountCategory_id = @accountCategory_id;";

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
        public static bool DeleteAccountCategory(string id)
        {
            #region SQL Parameter
            var idParam = new MySqlParameter("@accountCategory_id", MySqlDbType.Int64)
            {
                Direction = System.Data.ParameterDirection.Input,
                Value = id
            };
            #endregion

            string sql = "DELETE FROM tAccount_Categories WHERE accountCategory_id = @accountCategory_id ;";

            if (Connection.RunDMLCommand(sql) > 0)
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
