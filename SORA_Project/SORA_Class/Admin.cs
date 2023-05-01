﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlX.XDevAPI.Common;

namespace SORA_Class
{
    internal class Admin
    {
        private string id;
        private string firstName;
        private string lastName;
        private string email;
        private string phoneNumber;
        private DateTime dateOfBirth;

        private string password;
        private string password_salt;

        public string Id { get => id; set => id = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Email { get => email; set => email = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string Password { get => password; set => password = value; }
        public string Password_salt { get => password_salt; set => password_salt = value; }

        public Admin(string id, string firstName, string lastName, string email, string phoneNumber, DateTime dateOfBirth, string password, string password_salt = "")
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            DateOfBirth = dateOfBirth;
            Password = password;
            Password_salt = password_salt;
        }

        public Admin()
        {
            Id = "";
            FirstName = "";
            LastName = "";
            Email = "";
            PhoneNumber = "";
            DateOfBirth = DateTime.Now;
        }


        public static bool AddAdmin(Admin admin)
        {
            #region SQL Parameter
            var idParam = new MySqlParameter("@admin_id", MySqlDbType.Int64)
            {
                Direction = System.Data.ParameterDirection.Input,
                Value = admin.Id
            };

            var firstNameParam = new MySqlParameter("@first_name", MySqlDbType.VarChar, 45)
            {
                Direction = System.Data.ParameterDirection.Input,
                Value = admin.FirstName
            };
            var lastNameParam = new MySqlParameter("@last_name", MySqlDbType.VarChar, 45)
            {
                Direction = System.Data.ParameterDirection.Input,
                Value = admin.LastName
            };
            var emailParam = new MySqlParameter("@email", MySqlDbType.VarChar, 45)
            {
                Direction = System.Data.ParameterDirection.Input,
                Value = admin.Email
            };
            var passwordParam = new MySqlParameter("@password", MySqlDbType.VarChar, 128)
            {
                Direction = System.Data.ParameterDirection.Input,
                Value = admin.Password
            };
            var passwordSaltParam = new MySqlParameter("@password", MySqlDbType.VarChar, 32)
            {
                Direction = System.Data.ParameterDirection.Input,
                Value = admin.Password_salt
            };
            var phoneNumberParam = new MySqlParameter("@phone_number", MySqlDbType.VarChar, 15)
            {
                Direction = System.Data.ParameterDirection.Input,
                Value = admin.PhoneNumber
            };
            var dobParam = new MySqlParameter("@dob", MySqlDbType.Date)
            {
                Direction = System.Data.ParameterDirection.Input,
                Value = admin.DateOfBirth
            };
            #endregion

            string sql = "INSERT INTO 'tAdmins' ('id', 'first_name', 'last_name', 'email', 'dob', 'password') VALUES (@id, @first_name, @last_name, @email, @dob, @password);";

            Connection connection = new Connection();

            if (MySqlHelper.ExecuteNonQuery(connection.DbConnection, sql, idParam, firstNameParam, lastNameParam, emailParam, passwordParam, passwordSaltParam, phoneNumberParam, dobParam) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool UpdateAdmin(Admin admin)
        {
            #region SQL Parameter
            var idParam = new MySqlParameter("@admin_id", MySqlDbType.Int64)
            {
                Direction = System.Data.ParameterDirection.Input,
                Value = admin.Id
            };

            var firstNameParam = new MySqlParameter("@first_name", MySqlDbType.VarChar, 45)
            {
                Direction = System.Data.ParameterDirection.Input,
                Value = admin.FirstName
            };
            var lastNameParam = new MySqlParameter("@last_name", MySqlDbType.VarChar, 45)
            {
                Direction = System.Data.ParameterDirection.Input,
                Value = admin.LastName
            };
            var emailParam = new MySqlParameter("@email", MySqlDbType.VarChar, 45)
            {
                Direction = System.Data.ParameterDirection.Input,
                Value = admin.Email
            };
            var passwordParam = new MySqlParameter("@password", MySqlDbType.VarChar, 128)
            {
                Direction = System.Data.ParameterDirection.Input,
                Value = admin.Password
            };
            var passwordSaltParam = new MySqlParameter("@password", MySqlDbType.VarChar, 32)
            {
                Direction = System.Data.ParameterDirection.Input,
                Value = admin.Password_salt
            };
            var phoneNumberParam = new MySqlParameter("@phone_number", MySqlDbType.VarChar, 15)
            {
                Direction = System.Data.ParameterDirection.Input,
                Value = admin.PhoneNumber
            };
            var dobParam = new MySqlParameter("@dob", MySqlDbType.Date)
            {
                Direction = System.Data.ParameterDirection.Input,
                Value = admin.DateOfBirth
            };
            #endregion

            string sql = "UPDATE 'tAdmins' SET'first_name' = @first_name, 'last_name' = @last_name, 'email' = @email, 'phone_number' = @phone_number, 'dob' = @dob, 'password' = @password;" ;

            Connection connection = new Connection();

            if (MySqlHelper.ExecuteNonQuery(connection.DbConnection, sql, idParam, firstNameParam, lastNameParam, emailParam, passwordParam, passwordSaltParam, phoneNumberParam, dobParam) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool DeleteAdmin(string id)
        {
            #region SQL Parameter
            var idParam = new MySqlParameter("@admin_id", MySqlDbType.Int64)
            {
                Direction = System.Data.ParameterDirection.Input,
                Value = id
            };
            #endregion

            string sql = "DELETE FROM tAdmins WHERE id = @admin_id ;";

            if (Connection.RunDMLCommand(sql) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Admin CheckLogin(string email, string password)
        {

            #region SQL Parameter
            var emailParam = new MySqlParameter("@email", MySqlDbType.Int64)
            {
                Direction = System.Data.ParameterDirection.Input,
                Value = email
            };
            var passwordParam = new MySqlParameter("@password", MySqlDbType.Int64)
            {
                Direction = System.Data.ParameterDirection.Input,
                Value = password
            };
            #endregion


            if (CheckPassword(email, password) == false)
            {
                return null;
            }
            else
            {
                string sql = "SELECT * FROM tAdmins " + "WHERE password = @password AND email = @email;";

                MySqlDataReader result = Connection.RunQueryCommand(sql);

                Admin login = new Admin();

                if (result.Read() == true)
                {
                    login.Id = result.GetValue(0).ToString();
                    login.FirstName = result.GetValue(1).ToString();
                    login.LastName = result.GetValue(2).ToString();
                    login.Email = result.GetValue(3).ToString();
                    login.DateOfBirth = DateTime.Parse(result.GetValue(7).ToString());
                }

                return login;
            }
            
        }

        public static bool CheckPassword(string email, string password)
        {
            #region SQL Parameter
            var emailParam = new MySqlParameter("@email", MySqlDbType.Int64)
            {
                Direction = System.Data.ParameterDirection.Input,
                Value = email
            };
            var passwordParam = new MySqlParameter("@password", MySqlDbType.Int64)
            {
                Direction = System.Data.ParameterDirection.Input,
                Value = password
            };
            #endregion

            string sql = "SELECT email FROM tAdmins " + "WHERE tAdmins.password = @password AND tAdmins.email = @email;";

            MySqlDataReader result = Connection.RunQueryCommand(sql);
            string userEmail = "";

            if (result.Read() == true)
            {
                userEmail = result.GetString("email");
            }

            if (userEmail != null && userEmail != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static List<Admin> ReadData(string email)
        {

            #region SQL Parameter
            var emailParam = new MySqlParameter("@email", MySqlDbType.Int64)
            {
                Direction = System.Data.ParameterDirection.Input,
                Value = email
            };
            #endregion
            string sql = "SELECT * from tAdmins";

            if (email != "")
            {
                sql += " WHERE email = @email;";
            }

            MySqlDataReader result = Connection.RunQueryCommand(sql);
            List<Admin> listAdmin = new List<Admin>();

            while (result.Read() == true)
            {
                Customer customerLogin = new Customer();
                customerLogin.Id = result.GetValue(0).ToString();
                customerLogin.FirstName = result.GetValue(1).ToString();
                customerLogin.LastName = result.GetValue(2).ToString();
                customerLogin.Email = result.GetValue(3).ToString();
                customerLogin.PhoneNumber = result.GetValue(6).ToString();
                customerLogin.DateOfBirth = DateTime.Parse(result.GetValue(7).ToString());

            }
            return listAdmin;
        }

        public static void UpdateLastLogin(string id)
        {

            #region SQL Parameter
            var idParam = new MySqlParameter("@admin_id", MySqlDbType.Int64)
            {
                Direction = System.Data.ParameterDirection.Input,
                Value = id
            };
            #endregion
            string sql = "UPDATE tCustomers SET 'last_login' = NOW() WHERE idCustomer = @admin_id;";
        
        }

    }
}
