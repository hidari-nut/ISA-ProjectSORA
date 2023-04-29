using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System.Web.Helpers;
using System.Security.Cryptography;

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
        private int banned;


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
        public int Banned { get => banned; set => banned = value; }
        public string Pin { get => pin; set => pin = value; }
        public string Password { get => password; set => password = value; }
        public string Pin_salt { get => pin_salt; set => pin_salt = value; }
        public string Password_salt { get => password_salt; set => password_salt = value; }

        public Customer(string id, string firstName, string lastName, string email, string phoneNumber, 
            DateTime dateOfBirth, decimal balance, int banned, string pin, string password, 
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
            Banned = 0;
        }

        /// <summary>
        /// Generates a salt, salts the password, and hashes the salted password
        /// </summary>
        /// <param name="plainPassword">Plaintext password</param>
        /// <returns>A tuple (hashedSaltedPassword, salt)</returns>
        public static (string, string) SaltAndHashPassword(string plainPassword)
        {
            string salt = Crypto.GenerateSalt(16);
            string saltedPassword = salt + plainPassword;

            string hashedPassword = Crypto.HashPassword(saltedPassword);
            return (hashedPassword, salt);
        }

        /// <summary>
        /// Hashes a password based on the salt inputted. Leaving salt empty means hashing the password with no salt.
        /// </summary>
        /// <param name="plainPassword">Plaintext password</param>
        /// <param name="salt">Password salt [Optional]</param>
        /// <returns>A hashed password (Hashed salted password, if salt is inputted)</returns>
        public static string HashPassword(string plainPassword, string salt = "") 
        {
            string saltedPassword = salt + plainPassword;
            string hashedPassword = Crypto.HashPassword(saltedPassword);
            return hashedPassword;
        }

        public static bool Add(Customer customer)
        {
            string plainPassword = customer.Password;

            //Salt and Hash Password
            (string, string) hashedAndSaltPassword = Customer.SaltAndHashPassword(customer.Password);
            customer.Password = hashedAndSaltPassword.Item1;
            customer.Password_salt = hashedAndSaltPassword.Item2;

            //UTF-8 Encoding will be used to convert strings to bytes and vice versa.
            var utf8 = new UTF8Encoding();

            Rfc2898DeriveBytes passKey = new Rfc2898DeriveBytes(utf8.GetBytes(plainPassword), utf8.GetBytes(customer.Password_salt),
                100000, HashAlgorithmName.SHA512);

            Aes aesKeyEncrypt = Aes.Create();
            aesKeyEncrypt.Key = passKey.GetBytes(32);

            //Encrypt customer's data with AES

            //Creating a new Aes object generates a key and an IV (Initialization Vector)
            using (Aes aesData = Aes.Create())
            {

                //e means encrypted
                // Encrypt the string to an array of bytes.
                byte[] eFirstName = AES.EncryptStringToBytes_Aes(customer.FirstName, aesData.Key, aesData.IV);
                byte[] eLastName = AES.EncryptStringToBytes_Aes(customer.LastName, aesData.Key, aesData.IV);
                byte[] ePhoneNumber = AES.EncryptStringToBytes_Aes(customer.PhoneNumber, aesData.Key, aesData.IV);
                byte[] eDateOfBirth = AES.EncryptStringToBytes_Aes(customer.DateOfBirth.ToString("yyyy-MM-dd hh:mm:ss"), 
                    aesData.Key, aesData.IV);
                byte[] eBalance = AES.EncryptStringToBytes_Aes(customer.Balance.ToString(), aesData.Key, aesData.IV);

                // Encrypt the data key with the user's password derivation as key.
                byte[] eDataKey = AES.EncryptStringToBytes_Aes(utf8.GetString(aesData.Key), aesKeyEncrypt.Key, aesKeyEncrypt.IV);

                //// Decrypt the bytes to a string.
                //string roundtrip = AES.DecryptStringFromBytes_Aes(encrypted, myAes.Key, myAes.IV);

                ////Display the original data and the decrypted data.
                //Console.WriteLine("Original:   {0}", original);
                //Console.WriteLine("Round Trip: {0}", roundtrip);


                //Double hash
                customer.Password = HashPassword(customer.Password);

                //Salt and Hash PIN
                (string, string) hashedAndSaltPIN = Customer.SaltAndHashPassword(customer.Pin);
                customer.Pin = hashedAndSaltPIN.Item1;
                customer.Pin_salt = hashedAndSaltPIN.Item2;




                string sql = "INSERT INTO tcustomers (idcustomer, first_name, last_name, email, phone_number, " +
                    "dob, pin, password, balance, pin_salt, password_salt, ban, last_login, rsa_public_key, rsa_private_key," +
                    "aes_iv, aes_key) VALUES ('" +
                    customer.Id + "','" + eFirstName + "','" + eLastName + "','" + customer.Email +
                    "','" + ePhoneNumber + "','" + eDateOfBirth + "','" +
                    customer.Pin + "','" + customer.Password + "'," + eBalance + ", '" + customer.Pin_salt
                    + "', '" + customer.Password_salt + "', " + customer.Banned + ", '" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")
                    + "');";
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


        public static bool Update(Customer customer)
        {
            string sql = "UPDATE 'tCustomers' SET'first_name' = '" + customer.FirstName 
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
            string sql = "DELETE FROM tCustomers WHERE id = '" + id + "';";

            if (Connection.RunDMLCommand(sql) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Customer CheckLogin(string email,string password)
        {
            if (CheckPassword(email, password) == false)
            {
                return null;
            }
            else
            {
                string sql = "SELECT * FROM tCustomers " + "WHERE email = '" + email + "';";

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
                    login.Banned = int.Parse(result.GetValue(11).ToString());
                }

                if(login.Banned == 1)
                    return null;
                else
                    return login;
            }
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

        public static List<Customer> ReadData(string email) 
        {
            string sql = "SELECT * from tCustomers";

            if(email != "")
            {
                sql += " WHERE email = " + email + ";"; 
            }

            MySqlDataReader result = Connection.RunQueryCommand(sql);
            List<Customer> listCustomer = new List<Customer>();

            while (result.Read() == true)
            {
                Customer customerLogin = new Customer();
                customerLogin.Id = result.GetValue(0).ToString();
                customerLogin.FirstName = result.GetValue(1).ToString();
                customerLogin.LastName = result.GetValue(2).ToString();
                customerLogin.Email = result.GetValue(3).ToString();
                customerLogin.PhoneNumber = result.GetValue(4).ToString();
                customerLogin.DateOfBirth = DateTime.Parse(result.GetValue(5).ToString());
                customerLogin.Pin = result.GetValue(6).ToString();
                customerLogin.Password = result.GetValue(8).ToString();
                customerLogin.Balance = int.Parse(result.GetValue(10).ToString());

            }
            return listCustomer;
        }

        public static void UpdateLastLogin(string customerId)
        {
            string sql = "UPDATE tCustomers SET 'last_login' = NOW() WHERE idCustomer = '" + customerId + "';";
        }

        public static void BanUpdate(string customerId)
        {
            string sql = "UPDATE 'tCustomers' SET'ban' = 1 WHERE idCustomer = '" + customerId + "';";
        }
    }
}
