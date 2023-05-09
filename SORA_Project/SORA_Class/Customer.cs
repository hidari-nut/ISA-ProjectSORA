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

        private DateTime lastLogin;
        private Byte[] dataIV;
        private Byte[] dataKey;
        private Byte[] keyIV;

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
        public DateTime LastLogin { get => lastLogin; set => lastLogin = value; }
        public byte[] DataIV { get => dataIV; set => dataIV = value; }
        public byte[] DataKey { get => dataKey; set => dataKey = value; }
        public byte[] KeyIV { get => keyIV; set => keyIV = value; }

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
            var utf16 = new UnicodeEncoding();

            Rfc2898DeriveBytes passKey = new Rfc2898DeriveBytes(utf16.GetBytes(plainPassword), utf16.GetBytes(customer.Password_salt),
                100000, HashAlgorithmName.SHA512);

            Aes aesKeyEncrypt = Aes.Create();
            aesKeyEncrypt.Key = passKey.GetBytes(32);

            //Create RSA Keys and Encrypt the Private Key.
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
            byte[] publicKeyRSA = RSA.ExportRSAPublicKey();
            byte[] privateKeyRSA = RSA.ExportPkcs8PrivateKey();

            privateKeyRSA = AES.EncryptStringToBytes_Aes(utf16.GetString(privateKeyRSA), aesKeyEncrypt.Key, aesKeyEncrypt.IV);


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
                byte[] eDataKey = AES.EncryptStringToBytes_Aes(utf16.GetString(aesData.Key), aesKeyEncrypt.Key, aesKeyEncrypt.IV);

                //// Decrypt the bytes to a string.
                //string roundtrip = AES.DecryptStringFromBytes_Aes(encrypted, myAes.Key, myAes.IV);

                ////Display the original data and the decrypted data.
                //Console.WriteLine("Original:   {0}", original);
                //Console.WriteLine("Round Trip: {0}", roundtrip);

                //Salt and Hash PIN
                (string, string) hashedAndSaltPIN = Customer.SaltAndHashPassword(customer.Pin);
                customer.Pin = hashedAndSaltPIN.Item1;
                customer.Pin_salt = hashedAndSaltPIN.Item2;




                //string sql = "INSERT INTO tcustomers (idcustomer, first_name, last_name, email, phone_number, " +
                //    "dob, pin, password, balance, pin_salt, password_salt, ban, last_login," +
                //    "aes_data_iv, aes_data_key, aes_key_iv) VALUES ('" +
                //    customer.Id + "','" + eFirstName + "','" + eLastName + "','" + customer.Email +
                //    "','" + ePhoneNumber + "','" + eDateOfBirth + "','" +
                //    customer.Pin + "','" + customer.Password + "'," + eBalance + ", '" + customer.Pin_salt
                //    + "', '" + customer.Password_salt + "', " + customer.Banned + ", '" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")
                //    + "', " +");";

                //Use SQL Parameters to avoid SQL Injection attacks
                const string sql = "INSERT INTO tcustomers(idcustomer, first_name, last_name, email, phone_number, " +
                    "dob, pin, password, balance, pin_salt, password_salt, ban, last_login, " +
                    "aes_data_iv, aes_data_key, aes_key_iv, rsa_private_key, rsa_public_key) " +
                    "VALUES(@idcustomer, @first_name, @last_name, @email, @phone_number, " +
                    "@dob, @pin, @password, @balance, @pin_salt, @password_salt, @ban, @last_login, " +
                    "@aes_data_iv, @aes_data_key, @aes_key_iv, @rsa_private_key, @rsa_public_key)";

                #region SQL Parameters
                var idParam = new MySqlParameter("@idcustomer", MySqlDbType.VarChar, 45)
                {
                    Direction = ParameterDirection.Input,
                    Value = customer.Id
                };

                var firstNameParam = new MySqlParameter("@first_name", MySqlDbType.VarBinary)
                {
                    Direction = ParameterDirection.Input,
                    Size = eFirstName.Length,
                    Value = eFirstName
                };
                var lastNameParam = new MySqlParameter("@last_name", MySqlDbType.VarBinary)
                {
                    Direction = ParameterDirection.Input,
                    Size = eLastName.Length,
                    Value = eLastName
                };
                var emailParam = new MySqlParameter("@email", MySqlDbType.VarChar, 45)
                {
                    Direction = ParameterDirection.Input,
                    Value = customer.Email
                };
                var phoneNumberParam = new MySqlParameter("@phone_number", MySqlDbType.VarBinary)
                {
                    Direction = ParameterDirection.Input,
                    Size = ePhoneNumber.Length,
                    Value = ePhoneNumber
                };
                var dobParam = new MySqlParameter("@dob", MySqlDbType.VarBinary)
                {
                    Direction = ParameterDirection.Input,
                    Size = eDateOfBirth.Length,
                    Value = eDateOfBirth
                };
                var pinParam = new MySqlParameter("@pin", MySqlDbType.VarChar, 128)
                {
                    Direction = ParameterDirection.Input,
                    Value = customer.Pin
                };
                var passwordParam = new MySqlParameter("@password", MySqlDbType.VarChar, 128)
                {
                    Direction = ParameterDirection.Input,
                    Value = customer.Password
                };
                var balanceParam = new MySqlParameter("@balance", MySqlDbType.VarBinary) 
                { 
                    Direction = ParameterDirection.Input,
                    Size = eBalance.Length,
                    Value = eBalance 
                };
                var pinSaltParam = new MySqlParameter("@pin_salt", MySqlDbType.VarChar, 32)
                {
                    Direction = ParameterDirection.Input,
                    Value = customer.Pin_salt
                };
                var passwordSaltParam = new MySqlParameter("@password_salt", MySqlDbType.VarChar, 32)
                {
                    Direction = ParameterDirection.Input,
                    Value = customer.Password_salt
                };
                var banParam = new MySqlParameter("@ban", MySqlDbType.Int64, 8)
                {
                    Direction = ParameterDirection.Input,
                    Value = customer.Banned
                };
                var lastLoginParam = new MySqlParameter("@last_login", MySqlDbType.DateTime)
                {
                    Direction = ParameterDirection.Input,
                    Value = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")
                };
                var dataIVParam = new MySqlParameter("@aes_data_iv", MySqlDbType.VarBinary)
                {
                    Direction = ParameterDirection.Input,
                    Size = aesData.IV.Length,
                    Value = aesData.IV
                };
                var dataKeyParam = new MySqlParameter("@aes_data_key", MySqlDbType.VarBinary)
                {
                    Direction = ParameterDirection.Input,
                    Value = eDataKey
                };
                var keyIVParam = new MySqlParameter("@aes_key_iv", MySqlDbType.VarBinary)
                {
                    Direction = ParameterDirection.Input,
                    Size = aesKeyEncrypt.IV.Length,
                    Value = aesKeyEncrypt.IV
                };
                var privateKeyRSAParam = new MySqlParameter("@rsa_private_key", MySqlDbType.VarBinary)
                {
                    Direction = ParameterDirection.Input,
                    Size = privateKeyRSA.Length,
                    Value = privateKeyRSA
                };
                var publicKeyRSAParam = new MySqlParameter("@rsa_public_key", MySqlDbType.VarBinary)
                {
                    Direction = ParameterDirection.Input,
                    Size = publicKeyRSA.Length,
                    Value = publicKeyRSA
                };

                #endregion

                Connection connection = new Connection();


                if (MySqlHelper.ExecuteNonQuery(connection.DbConnection, sql, idParam, firstNameParam, lastNameParam,
                    emailParam, phoneNumberParam, dobParam, pinParam, passwordParam, balanceParam, pinSaltParam,
                    passwordSaltParam, banParam, lastLoginParam, dataIVParam, dataKeyParam, keyIVParam,
                    privateKeyRSAParam, publicKeyRSAParam) > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        /// <summary>
        /// Updates the balance of a customer
        /// </summary>
        /// <param name="customer">Designated customer</param>
        /// <param name="plainPassword">Customer's plaintext password</param>
        /// <returns>If the update is successful</returns>
        public static bool UpdateBalance(Customer customer, string plainPassword)
        {
            //UTF-8 Encoding will be used to convert strings to bytes and vice versa.
            var utf16 = new UnicodeEncoding();

            //Derive password hash to decrypt data key
            Rfc2898DeriveBytes passKey = new Rfc2898DeriveBytes(utf16.GetBytes(plainPassword),
            utf16.GetBytes(customer.Password_salt),
            100000, HashAlgorithmName.SHA512);

            Aes aesKeyEncrypt = Aes.Create();
            aesKeyEncrypt.Key = passKey.GetBytes(32);
            aesKeyEncrypt.IV = customer.KeyIV;

            using (Aes aesData = Aes.Create())
            {
                //Decrypt key
                string dataKey = AES.DecryptStringFromBytes_Aes(customer.DataKey, aesKeyEncrypt.Key, aesKeyEncrypt.IV);

                aesData.Key = utf16.GetBytes(dataKey);
                aesData.IV = customer.DataIV;

                //Encrypt Balance
                byte[] eBalance = AES.EncryptStringToBytes_Aes(customer.Balance.ToString(), aesData.Key, aesData.IV);

                string sql = "UPDATE tCustomers SET balance = @balance, last_login = @last_login " +
                    "WHERE idCustomer = @idcustomer";

                #region SQL Parameters
                var idParam = new MySqlParameter("@idcustomer", MySqlDbType.VarChar, 45)
                {
                    Direction = ParameterDirection.Input,
                    Value = customer.Id
                };
                var balanceParam = new MySqlParameter("@balance", MySqlDbType.VarBinary)
                {
                    Direction = ParameterDirection.Input,
                    Size = eBalance.Length,
                    Value = eBalance
                };
                var lastLoginParam = new MySqlParameter("@last_login", MySqlDbType.DateTime)
                {
                    Direction = ParameterDirection.Input,
                    Value = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")
                };
                #endregion

                Connection connection = new Connection();


                if (MySqlHelper.ExecuteNonQuery(connection.DbConnection, sql, idParam, 
                    balanceParam, lastLoginParam) > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        /// <summary>
        /// Updates the balance of a Customer
        /// </summary>
        /// <param name="customer">Designated customer</param>
        /// <param name="plainPassword">Customer's plaintext password</param>
        /// <param name="connection">Connection used, Inputted if TransactionScope is used</param>
        /// <returns>If the update is successful</returns>
        public static bool UpdateBalance(Customer customer, string plainPassword, Connection connection)
        {
            //UTF-8 Encoding will be used to convert strings to bytes and vice versa.
            var utf16 = new UnicodeEncoding();

            //Derive password hash to decrypt data key
            Rfc2898DeriveBytes passKey = new Rfc2898DeriveBytes(utf16.GetBytes(plainPassword),
            utf16.GetBytes(customer.Password_salt),
            100000, HashAlgorithmName.SHA512);

            Aes aesKeyEncrypt = Aes.Create();
            aesKeyEncrypt.Key = passKey.GetBytes(32);
            aesKeyEncrypt.IV = customer.KeyIV;

            using (Aes aesData = Aes.Create())
            {
                //Decrypt key
                string dataKey = AES.DecryptStringFromBytes_Aes(customer.DataKey, aesKeyEncrypt.Key, aesKeyEncrypt.IV);

                aesData.Key = utf16.GetBytes(dataKey);
                aesData.IV = customer.DataIV;

                //Encrypt Balance
                byte[] eBalance = AES.EncryptStringToBytes_Aes(customer.Balance.ToString(), aesData.Key, aesData.IV);

                string sql = "UPDATE tCustomers SET balance = @balance, last_login = @last_login " +
                    "WHERE idCustomer = @idcustomer";

                #region SQL Parameters
                var idParam = new MySqlParameter("@idcustomer", MySqlDbType.VarChar, 45)
                {
                    Direction = ParameterDirection.Input,
                    Value = customer.Id
                };
                var balanceParam = new MySqlParameter("@balance", MySqlDbType.VarBinary)
                {
                    Direction = ParameterDirection.Input,
                    Size = eBalance.Length,
                    Value = eBalance
                };
                var lastLoginParam = new MySqlParameter("@last_login", MySqlDbType.DateTime)
                {
                    Direction = ParameterDirection.Input,
                    Value = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")
                };
                #endregion

                if (MySqlHelper.ExecuteNonQuery(connection.DbConnection, sql, idParam,
                    balanceParam, lastLoginParam) > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
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
            string sql = "SELECT password, password_salt FROM tcustomers WHERE tcustomers.email = @email;";

            #region SQL Parameters
            var emailParam = new MySqlParameter("@email", MySqlDbType.VarChar, 45)
            {
                Direction = System.Data.ParameterDirection.Input,
                Value = email
            };
            #endregion

            Connection connection = new Connection();
            MySqlDataReader result = MySqlHelper.ExecuteReader(connection.DbConnection, sql, emailParam);
            string userEmail = "";
            string userPassword = "";
            string userPasswordSalt = "";

            while (result.Read() == true)
            {
                userPassword = result.GetString("password");
                userPasswordSalt = result.GetString("password_salt");
            }

            string saltedPlain = userPasswordSalt + password;

            string onceHashed = Crypto.HashPassword(saltedPlain);

            //Second hash done in verify method.
            if (Crypto.VerifyHashedPassword(userPassword, saltedPlain) == true)
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
            string sql = "SELECT pin, pin_salt FROM tcustomers " + "WHERE tcustomers.email = @email;";

            #region SQL Parameters
            var emailParam = new MySqlParameter("@email", MySqlDbType.VarChar, 45)
            {
                Direction = System.Data.ParameterDirection.Input,
                Value = email
            };
            #endregion

            Connection connection = new Connection();
            MySqlDataReader result = MySqlHelper.ExecuteReader(connection.DbConnection, sql, emailParam);
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

        /// <summary>
        /// Returns the RSA Public Key of a specified user using user's email.
        /// </summary>
        /// <param name="email">Specified User's Email</param>
        /// <returns>RSA Public Key of specified User in byte array</returns>
        public static byte[] GetRSAPublicKey(string customerID)
        {
            byte[] publicKeyRSA = null;

            string sql = "SELECT rsa_public_key FROM tCustomers WHERE idCustomer = @idCustomer";

            var idParam = new MySqlParameter("@idCustomer", MySqlDbType.VarChar, 45)
            {
                Direction = ParameterDirection.Input,
                Value = customerID
            };

            Connection connection = new Connection();
            MySqlDataReader result = MySqlHelper.ExecuteReader(connection.DbConnection, sql, idParam);

            if (result.Read() == true)
            {
                publicKeyRSA = (byte[])(result["rsa_public_key"]);
            }

            return publicKeyRSA;
        }

        /// <summary>
        /// Returns the RSA Private Key of a specified user using user's email and password
        /// </summary>
        /// <param name="email">User's email</param>
        /// <param name="password">User's password</param>
        /// <returns>RSA Private Key of the User in byte array</returns>
        public static byte[] GetRSAPrivateKey(string email, string password)
        {
            byte[] encryptedPrivateKeyRSA = null;
            byte[] privateKeyRSA = null;
            string passwordSalt = "";
            byte[] keyIV = null;

            string sql = "SELECT rsa_private_key, password_salt FROM tCustomers WHERE email = @email";

            var emailParam = new MySqlParameter("@email", MySqlDbType.VarChar, 45)
            {
                Direction = ParameterDirection.Input,
                Value = email
            };

            Connection connection = new Connection();
            MySqlDataReader result = MySqlHelper.ExecuteReader(connection.DbConnection, sql, emailParam);

            if (result.Read() == true)
            {
                encryptedPrivateKeyRSA = (byte[])(result["rsa_private_key"]);
                passwordSalt = result.GetValue(2).ToString();
                keyIV = (byte[])(result["aes_key_iv"]);
            }

            //UTF-8 Encoding will be used to convert strings to bytes and vice versa.
            var utf16 = new UnicodeEncoding();

            Rfc2898DeriveBytes passKey = new Rfc2898DeriveBytes(utf16.GetBytes(password), 
                utf16.GetBytes(passwordSalt),
                100000, HashAlgorithmName.SHA512);

            Aes aesKeyEncrypt = Aes.Create();
            aesKeyEncrypt.Key = passKey.GetBytes(32);
            aesKeyEncrypt.IV = keyIV;

            string privateKeyRSAString = AES.DecryptStringFromBytes_Aes(encryptedPrivateKeyRSA, 
                aesKeyEncrypt.Key, aesKeyEncrypt.IV);

            privateKeyRSA = utf16.GetBytes(privateKeyRSAString);

            return privateKeyRSA;
        }

        public static Customer ReadData(string email, string password) 
        {
            string sql = "SELECT * from tCustomers WHERE email = @email;";

            #region SQL Parameters
            var emailParam = new MySqlParameter("@email", MySqlDbType.VarChar, 45)
            {
                Direction = System.Data.ParameterDirection.Input,
                Value = email
            };
            #endregion

            Connection connection = new Connection();
            MySqlDataReader result = MySqlHelper.ExecuteReader(connection.DbConnection, sql, emailParam);

            Customer customerLogin = new Customer();
            byte[] customerFirstNameBytes;
            byte[] customerLastNameBytes;
            byte[] customerPhoneNumberBytes;
            byte[] customerDOBBytes;
            byte[] customerBalanceBytes;

            var utf16 = new UnicodeEncoding();

            if (result.Read() == true)
            {
                customerLogin.Id = result.GetValue(0).ToString();
                customerFirstNameBytes = (byte[])(result["first_name"]); //Bytes
                customerLastNameBytes = (byte[])(result["last_name"]); //Bytes
                customerLogin.Email = result.GetValue(3).ToString();
                customerPhoneNumberBytes = (byte[])(result["phone_number"]); //Bytes
                customerDOBBytes = (byte[])(result["dob"]); //Bytes
                customerLogin.Pin = result.GetValue(6).ToString();
                customerLogin.Pin_salt = result.GetValue(7).ToString();
                customerLogin.Password = result.GetValue(8).ToString();
                customerLogin.Password_salt = result.GetValue(9).ToString();
                customerBalanceBytes = (byte[])(result["balance"]); //Bytes
                customerLogin.Banned = int.Parse(result.GetValue(11).ToString());
                customerLogin.LastLogin = DateTime.Parse(result.GetValue(12).ToString());
                customerLogin.DataIV = (byte[])(result["aes_data_iv"]); //Bytes
                customerLogin.DataKey = (byte[])(result["aes_data_key"]); //Bytes
                customerLogin.KeyIV = (byte[])(result["aes_key_iv"]); //Bytes

                //Derive password hash to decrypt data key
                Rfc2898DeriveBytes passKey = new Rfc2898DeriveBytes(utf16.GetBytes(password),
                utf16.GetBytes(customerLogin.Password_salt),
                100000, HashAlgorithmName.SHA512);

                Aes aesKeyEncrypt = Aes.Create();
                aesKeyEncrypt.Key = passKey.GetBytes(32);
                aesKeyEncrypt.IV = customerLogin.KeyIV;



                using (Aes aesData = Aes.Create())
                {
                    //Decrypt key
                    string dataKey = AES.DecryptStringFromBytes_Aes(customerLogin.DataKey, aesKeyEncrypt.Key, aesKeyEncrypt.IV);
                    
                    aesData.Key = utf16.GetBytes(dataKey);
                    aesData.IV = customerLogin.DataIV;
                    
                    //Decrypt data
                    customerLogin.FirstName = AES.DecryptStringFromBytes_Aes(customerFirstNameBytes, aesData.Key, aesData.IV);
                    customerLogin.LastName = AES.DecryptStringFromBytes_Aes(customerLastNameBytes, aesData.Key, aesData.IV);
                    customerLogin.PhoneNumber = AES.DecryptStringFromBytes_Aes(customerPhoneNumberBytes, aesData.Key, aesData.IV);
                    customerLogin.DateOfBirth = DateTime.Parse(AES.DecryptStringFromBytes_Aes(customerDOBBytes, 
                        aesData.Key, aesData.IV));
                    customerLogin.Balance = Decimal.Parse(AES.DecryptStringFromBytes_Aes(customerBalanceBytes,
                        aesData.Key, aesData.IV));
                }
            }

            return customerLogin;
        }

        public static Customer ReadData(string email, string password, Connection connection)
        {
            string sql = "SELECT * from tCustomers WHERE email = @email;";

            #region SQL Parameters
            var emailParam = new MySqlParameter("@email", MySqlDbType.VarChar, 45)
            {
                Direction = System.Data.ParameterDirection.Input,
                Value = email
            };
            #endregion

            MySqlDataReader result = MySqlHelper.ExecuteReader(connection.DbConnection, sql, emailParam);

            Customer customerLogin = new Customer();
            byte[] customerFirstNameBytes;
            byte[] customerLastNameBytes;
            byte[] customerPhoneNumberBytes;
            byte[] customerDOBBytes;
            byte[] customerBalanceBytes;

            var utf16 = new UnicodeEncoding();

            if (result.Read() == true)
            {
                customerLogin.Id = result.GetValue(0).ToString();
                customerFirstNameBytes = (byte[])(result["first_name"]); //Bytes
                customerLastNameBytes = (byte[])(result["last_name"]); //Bytes
                customerLogin.Email = result.GetValue(3).ToString();
                customerPhoneNumberBytes = (byte[])(result["phone_number"]); //Bytes
                customerDOBBytes = (byte[])(result["dob"]); //Bytes
                customerLogin.Pin = result.GetValue(6).ToString();
                customerLogin.Pin_salt = result.GetValue(7).ToString();
                customerLogin.Password = result.GetValue(8).ToString();
                customerLogin.Password_salt = result.GetValue(9).ToString();
                customerBalanceBytes = (byte[])(result["balance"]); //Bytes
                customerLogin.Banned = int.Parse(result.GetValue(11).ToString());
                customerLogin.LastLogin = DateTime.Parse(result.GetValue(12).ToString());
                customerLogin.DataIV = (byte[])(result["aes_data_iv"]); //Bytes
                customerLogin.DataKey = (byte[])(result["aes_data_key"]); //Bytes
                customerLogin.KeyIV = (byte[])(result["aes_key_iv"]); //Bytes

                //Derive password hash to decrypt data key
                Rfc2898DeriveBytes passKey = new Rfc2898DeriveBytes(utf16.GetBytes(password),
                utf16.GetBytes(customerLogin.Password_salt),
                100000, HashAlgorithmName.SHA512);

                Aes aesKeyEncrypt = Aes.Create();
                aesKeyEncrypt.Key = passKey.GetBytes(32);
                aesKeyEncrypt.IV = customerLogin.KeyIV;



                using (Aes aesData = Aes.Create())
                {
                    //Decrypt key
                    string dataKey = AES.DecryptStringFromBytes_Aes(customerLogin.DataKey, aesKeyEncrypt.Key, aesKeyEncrypt.IV);

                    aesData.Key = utf16.GetBytes(dataKey);
                    aesData.IV = customerLogin.DataIV;

                    //Decrypt data
                    customerLogin.FirstName = AES.DecryptStringFromBytes_Aes(customerFirstNameBytes, aesData.Key, aesData.IV);
                    customerLogin.LastName = AES.DecryptStringFromBytes_Aes(customerLastNameBytes, aesData.Key, aesData.IV);
                    customerLogin.PhoneNumber = AES.DecryptStringFromBytes_Aes(customerPhoneNumberBytes, aesData.Key, aesData.IV);
                    customerLogin.DateOfBirth = DateTime.Parse(AES.DecryptStringFromBytes_Aes(customerDOBBytes,
                        aesData.Key, aesData.IV));
                    customerLogin.Balance = Decimal.Parse(AES.DecryptStringFromBytes_Aes(customerBalanceBytes,
                        aesData.Key, aesData.IV));
                }
            }

            return customerLogin;
        }

        /// <summary>
        /// Updates Customer's last login to current time.
        /// </summary>
        /// <param name="customerId">Designated customer's id</param>
        /// <returns>If the update is successful</returns>
        public static bool UpdateLastLogin(string customerId)
        {
            string sql = "UPDATE tCustomers SET last_login = @last_login " +
                    "WHERE idCustomer = @idcustomer";

            #region SQL Parameters
            var idParam = new MySqlParameter("@idcustomer", MySqlDbType.VarChar, 45)
            {
                Direction = ParameterDirection.Input,
                Value = customerId
            };
            var lastLoginParam = new MySqlParameter("@last_login", MySqlDbType.DateTime)
            {
                Direction = ParameterDirection.Input,
                Value = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")
            };
            #endregion

            Connection connection = new Connection();


            if (MySqlHelper.ExecuteNonQuery(connection.DbConnection, sql, idParam,
                lastLoginParam) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Updates the customer's ban status.
        /// </summary>
        /// <param name="customerId">Designated customer's id</param>
        /// <returns>If the update is successful</returns>
        public static bool BanUpdate(string customerId, bool banStatus)
        {
            string sql = "UPDATE tCustomers SET ban = @ban " +
            "WHERE idCustomer = @idcustomer";

            int banInt = 0;
            if(banStatus == true)
            {
                banInt = 1;
            }
            else
            {
                banInt = 0;
            }

            #region SQL Parameters
            var idParam = new MySqlParameter("@idcustomer", MySqlDbType.VarChar, 45)
            {
                Direction = ParameterDirection.Input,
                Value = customerId
            };
            var banParam = new MySqlParameter("@ban", MySqlDbType.Int64, 8)
            {
                Direction = ParameterDirection.Input,
                Value = banInt
            };
            #endregion

            Connection connection = new Connection();


            if (MySqlHelper.ExecuteNonQuery(connection.DbConnection, sql, idParam,
                banParam) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Searches for customer's id by inputted email
        /// </summary>
        /// <param name="email">Customer's email address</param>
        /// <returns>Customer's ID</returns>
        public static string SearchByEmail(string email)
        {
          
            #region SQL Parameter
            var emailParam = new MySqlParameter("@email", MySqlDbType.VarChar,45)
            {
                Direction = System.Data.ParameterDirection.Input,
                Value = email
            };
            #endregion

            string sql = "SELECT idCustomer FROM tCustomers WHERE email = @email;";

            Connection connection = new Connection();
            MySqlDataReader result = MySqlHelper.ExecuteReader(connection.DbConnection, sql, emailParam);
            if (result.Read() == true)
            {
                string customerID = result.GetString(0);
                return customerID;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Searches for customer's id by inputted email
        /// </summary>
        /// <param name="email">Customer's email address</param>
        /// <param name="connection">Transaction's Connection</param>
        /// <returns>Customer's ID</returns>
        public static string SearchByEmail(string email, Connection connection)
        {

            #region SQL Parameter
            var emailParam = new MySqlParameter("@email", MySqlDbType.VarChar, 45)
            {
                Direction = System.Data.ParameterDirection.Input,
                Value = email
            };
            #endregion

            string sql = "SELECT idCustomer FROM tCustomers WHERE email = @email;";

            MySqlDataReader result = MySqlHelper.ExecuteReader(connection.DbConnection, sql, emailParam);
            if (result.Read() == true)
            {
                string customerID = result.GetString(0);
                return customerID;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Searches customer's email by id input
        /// </summary>
        /// <param name="id">Customer ID</param>
        /// <returns>Customer's Email address</returns>
        public static string SearchByID(string id)
        {

            #region SQL Parameter
            var idParam = new MySqlParameter("@idCustomer", MySqlDbType.VarChar, 45)
            {
                Direction = System.Data.ParameterDirection.Input,
                Value = id
            };
            #endregion

            string sql = "SELECT email FROM tCustomers WHERE idCustomer = @idCustomer;";

            Connection connection = new Connection();
            MySqlDataReader result = MySqlHelper.ExecuteReader(connection.DbConnection, sql, idParam);
            if (result.Read() == true)
            {
                string customerEmail = result.GetString(0);
                return customerEmail;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Searches customer's email by id input
        /// </summary>
        /// <param name="id">Customer ID</param>
        /// <param name="connection">Transaction Connection</param>
        /// <returns>Customer's Email address</returns>
        public static string SearchByID(string id, Connection connection)
        {

            #region SQL Parameter
            var idParam = new MySqlParameter("@idCustomer", MySqlDbType.VarChar, 45)
            {
                Direction = System.Data.ParameterDirection.Input,
                Value = id
            };
            #endregion

            string sql = "SELECT email FROM tCustomers WHERE idCustomer = @idCustomer;";

            MySqlDataReader result = MySqlHelper.ExecuteReader(connection.DbConnection, sql, idParam);
            if (result.Read() == true)
            {
                string customerEmail = result.GetString(0);
                return customerEmail;
            }
            else
            {
                return null;
            }
        }
    }
}
