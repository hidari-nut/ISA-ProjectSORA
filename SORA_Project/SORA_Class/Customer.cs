using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;

namespace SORA_Class
{
    internal class Customer
    {
        private string id;
        private string firstName;
        private string lastName;
        private string email;
        private string phoneNumber;
        private DateTime dateOfBirth;
        private decimal balance;
        private bool banned;

        private string pin;
        private string password;
        //private string pin_salt;
        //private string password_salt;

        public string Id { get => id; set => id = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Email { get => email; set => email = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public decimal Balance { get => balance; set => balance = value; }
        public bool Banned { get => banned; set => banned = value; }
        public string Pin { get => pin; set => pin = value; }
        public string Password { get => password; set => password = value; }

        public Customer(string id, string firstName, string lastName, string email, string phoneNumber, 
            DateTime dateOfBirth, decimal balance, bool banned, string pin, string password)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            DateOfBirth = dateOfBirth;
            Balance = balance;
            Banned = banned;
            Pin = pin;
            Password = password;
        }

        public Customer()
        {
            Id = "";
            FirstName = "";
            LastName = "";
            Email = "";
            PhoneNumber = "";
            DateOfBirth = DateTime.Now;
            Balance = 0;
            Banned = false;
        }

     

        public static bool TambahCustomer(Customer customer)
        {
            string sql = "INSERT INTO 'customer' ('id', 'first_name', 'last_name', 'email', 'phone_number', 'dob', 'pin', 'password', 'saldo') VALUES ('" +
                customer.Id + "','" + customer.FirstName + "','" + customer.LastName + "','" + customer.Email + "','" + customer.PhoneNumber + "','" + customer.DateOfBirth.ToString("yyyy-MM-dd hh:mm:ss") + "','" + customer.Pin + "','" + customer.Password + "'," + customer.Balance + ");";
            if (Connection.RunDMLCommand(sql) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool UpdateCustomer(Customer customer)
        {
            string sql = "UPDATE 'customer' SET'first_name' = '" + customer.FirstName + "', 'last_name' = '" + customer.LastName + "', 'email' = '" + customer.Email +"', 'phone_number' = '" + customer.PhoneNumber + "', 'dob' = '" + customer.DateOfBirth.ToString("yyyy-MM-dd hh:mm:ss") + "', 'customer' = '" + customer.Pin
                + "', 'password' = '" +customer.Password + "', 'saldo' = "+ customer.Balance; 
                
            if (Connection.RunDMLCommand(sql) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool HapusData(string id)
        {
            string sql = "DELETE FROM customer WHERE id = '" + id + "';";

            if (Connection.RunDMLCommand(sql) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Customer CheckLogin(string email, string password)
        {
            string sql = "SELECT * FROM customer " + "WHERE password = '" + password + "' AND email = '" + email + "';";

            MySqlDataReader result = Connection.RunQueryCommand(sql);

            Customer login = new Customer();

            if (result.Read() == true) 
            {
                login.Id = result.GetValue(0).ToString();
                login.FirstName = result.GetValue(1).ToString();
                login.LastName = result.GetValue(2).ToString();
                login.Email = result.GetValue(3).ToString();
                login.PhoneNumber = result.GetValue(4).ToString();
                login.DateOfBirth = DateTime.Parse(result.GetValue(5).ToString());
                login.Balance = int.Parse(result.GetValue(10).ToString());
            }

            return login;
        }

        public static bool CheckPassword(string email, string password) 
        {
            string sql = "SELECT email FROM customer " + "WHERE customer.password = '" + password + "' AND customer.email = '" + email + "';";

            MySqlDataReader result = Connection.RunQueryCommand(sql);
            string userEmail = "";

            if (result.Read() == true)
            {
                userEmail = result.GetString("email");
            }

            if(userEmail != null && userEmail != "")
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
            string sql = "SELECT email FROM customer " + "WHERE customer.password = '" + password + "' AND customer.email = '" + email + "';";

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
