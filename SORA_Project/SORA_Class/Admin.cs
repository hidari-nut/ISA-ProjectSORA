using MySql.Data.MySqlClient;
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

        public string Id { get => id; set => id = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Email { get => email; set => email = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string Password { get => password; set => password = value; }

        public Admin(string id, string firstName, string lastName, string email, string phoneNumber, DateTime dateOfBirth, string password)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            DateOfBirth = dateOfBirth;
            Password = password;
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
            string sql = "INSERT INTO 'tAdmins' ('id', 'first_name', 'last_name', 'email', 'dob', 'password') VALUES ('" +
                admin.Id + "','" + admin.FirstName + "','" + admin.LastName + "','" + admin.Email + "','" + admin.PhoneNumber + "','" + admin.DateOfBirth.ToString("yyyy-MM-dd hh:mm:ss") + "','" + admin.Password + "');";

            if (Connection.RunDMLCommand(sql) > 0)
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
            string sql = "UPDATE 'tAdmins' SET'first_name' = '" + admin.FirstName + "', 'last_name' = '" + admin.LastName + "', 'email' = '" + admin.Email + "', 'phone_number' = '" + admin.PhoneNumber + "', 'dob' = '" + admin.DateOfBirth.ToString("yyyy-MM-dd hh:mm:ss") + "',"
                + "', 'password' = '" + admin.Password + "';" ;
            if (Connection.RunDMLCommand(sql) > 0)
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
            string sql = "DELETE FROM tAdmins WHERE id = '" + id + "';";

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
            string sql = "SELECT * FROM tAdmins " + "WHERE password = '" + password + "' AND email = '" + email + "';";

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

        public static bool CheckPassword(string email, string password)
        {
            string sql = "SELECT email FROM tAdmins " + "WHERE tAdmins.password = '" + password + "' AND tAdmins.email = '" + email + "';";

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

        public static bool CheckPin(string email, string password)
        {
            string sql = "SELECT email FROM tAdmins " + "WHERE tAdmins.password = '" + password + "' AND tAdmins.email = '" + email + "';";

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

    }
}
