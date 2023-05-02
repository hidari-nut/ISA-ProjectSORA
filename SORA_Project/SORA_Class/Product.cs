using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SORA_Class
{
    internal class Product
    {
        private string id;
        private VerifiedAccount owner;
        private string name;
        private decimal price;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public decimal Price { get => price; set => price = value; }
        internal VerifiedAccount Owner { get => owner; set => owner = value; }

        public Product(string id, string name, decimal price, VerifiedAccount owner)
        {
            Id = id;
            Name = name;
            Price = price;
            Owner = owner;
        }

        public Product()
        {
            Id = "";
            Name = "";
            Price = 0;
            Owner = new VerifiedAccount();
        }

        public static bool AddProduct(Product product)
        {
            #region SQL PARAMETER
            var idParam = new MySqlParamater("@Product_id", MySqlDbType.Int64)
            {
                Direction = System.Data.ParameterDirection.Input,
                Value = product.Id
            };

            var nameParam = new MySqlParameter("@name", MySqlDbType.VarChar, 45)
            {
                Direction = System.Data.ParameterDirection.Input,
                Value = product.name
            };

            var priceParam = new MySqlParameter("@price", MySqlDbType.Decimal, 19.6)
            {
                Direction = System.Data.ParameterDirection.Input,
                Value = product.price
            };

            var ownerParam = new MySqlParameter("@owner", MySqlDbType.VarChar, 45)
            {
                Direction = System.Data.ParameterDirection.Input,
                Value = product.owner
            };

            #endregion
            string sql = "INSERT INTO tProduct(product_id, name, price, owner) VALUES " +
                "(@product_id, @name, @price, @owner);";

            Connection connection = new Connection();

            if (MySqlHelper.ExecuteNonQuery(connection.DbConnection, sql, idParam, nameParam, priceParam, ownerParam) > 0)
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
