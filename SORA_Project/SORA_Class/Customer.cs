using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System.Web.Helpers;

namespace SORA_Class
{
    public class Customer
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
        private string pin_salt;
        private string password_salt;

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
        public string Pin_salt { get => pin_salt; set => pin_salt = value; }
        public string Password_salt { get => password_salt; set => password_salt = value; }

        public Customer(string id, string firstName, string lastName, string email, string phoneNumber, 
            DateTime dateOfBirth, decimal balance, bool banned, string pin, string password, 
            string pin_salt = "", string password_salt = "")
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
            Pin_salt = pin_salt;
            Password_salt = password_salt;
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

        public static (string, string) SaltAndHashPassword(string plainPassword)
        {
            string salt = Crypto.GenerateSalt(16);
            string saltedPassword = salt + plainPassword;

            string hashedPassword = Crypto.HashPassword(saltedPassword);
            return (hashedPassword, salt);
        }

        public static string HashPassword(string plainPassword, string salt) 
        {
            string saltedPassword = salt + plainPassword;
            string hashedPassword = Crypto.HashPassword(saltedPassword);
            return hashedPassword;
        }

        public static bool Add(Customer customer)
        {
            //Salt and Hash Password
            (string, string) hashedAndSaltPassword = Customer.SaltAndHashPassword(customer.Password);
            customer.Password = hashedAndSaltPassword.Item1;
            customer.Password_salt = hashedAndSaltPassword.Item2;

            //Salt and Hash PIN
            (string, string) hashedAndSaltPIN = Customer.SaltAndHashPassword(customer.Pin);
            customer.Pin = hashedAndSaltPIN.Item1;
            customer.Pin_salt = hashedAndSaltPIN.Item2;


            string sql = "INSERT INTO tcustomers (idcustomer, first_name, last_name, email, phone_number, " +
                "dob, pin, password, balance, pin_salt, password_salt, ban) VALUES ('" +
                customer.Id + "','" + customer.FirstName + "','" + customer.LastName + "','" + customer.Email + 
                "','" + customer.PhoneNumber + "','" + customer.DateOfBirth.ToString("yyyy-MM-dd hh:mm:ss") + "','" + 
                customer.Pin + "','" + customer.Password + "'," + customer.Balance + ", '"+ customer.Pin_salt
                + "', '" + customer.Password_salt + "', " + customer.Banned + ");";
            if (Connection.RunDMLCommand(sql) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool Update(Customer customer)
        {
            string sql = "UPDATE 'customer' SET'first_name' = '" + customer.FirstName 
                + "', 'last_name' = '" + customer.LastName + "', 'email' = '" + customer.Email 
                +"', 'phone_number' = '" + customer.PhoneNumber 
                + "', 'dob' = '" + customer.DateOfBirth.ToString("yyyy-MM-dd hh:mm:ss") + "', 'pin' = '" + customer.Pin
                + "', 'password' = '" +customer.Password + "', 'saldo' = "+ customer.Balance +";"; 
                
            if (Connection.RunDMLCommand(sql) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool Delete(string id)
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
            string sql = "SELECT password, password_salt FROM tcustomers " + "WHERE tcustomers.email = '" + email + "';";

            MySqlDataReader result = Connection.RunQueryCommand(sql);
            string userEmail = "";
            string userPassword = "";
            string userPasswordSalt = "";

            while (result.Read() == true)
            {
                userPassword = result.GetString("password");
                userPasswordSalt = result.GetString("password_salt");
            }

            string saltedInputPassword = userPasswordSalt + password;


            if(Crypto.VerifyHashedPassword(userPassword, saltedInputPassword) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool CheckPin(string email, string pin) 
        {
            string sql = "SELECT pin, pin_salt FROM tcustomers " + "WHERE tcustomers.email = '" + email + "';";

            MySqlDataReader result = Connection.RunQueryCommand(sql);
            string userEmail = "";
            string userPIN = "";
            string userPINsalt = "";

            while (result.Read() == true)
            {
                userPIN = result.GetString("pin");
                userPINsalt = result.GetString("pin_salt");
            }

            string saltedInputPIN = userPINsalt + pin;

            if (Crypto.VerifyHashedPassword(userPIN, saltedInputPIN) == true)
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
