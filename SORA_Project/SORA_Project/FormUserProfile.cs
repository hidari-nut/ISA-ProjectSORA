using SORA_Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace SORA_Project
{
    public partial class FormUserProfile : Form
    {
        public FormUserProfile()
        {
            InitializeComponent();
        }

        private void FormUserProfile_Load(object sender, EventArgs e)
        {
            //(string, string) hashedPassword = Customer.SaltAndHashPassword("aPlainPassword");
            //string hashedSaltedPassword = hashedPassword.Item1;
            //string passwordSalt = hashedPassword.Item2;

            //string saltedPassword = "qfvNfOKcaKcvWqmOuMNNdw==" + "aPlainPassword";
            //bool passIsCorrect = Crypto.VerifyHashedPassword("AEjwGNVY26BHoZUcO3+qFfUrqascsqbsvnCcfmp6gzjvBqcia+dIfSy7AfGn3tYpOA==",
            //    saltedPassword);

            //MessageBox.Show("Plain password: aPlainPassword\n" +
            //    "Hashed password: " + "AEjwGNVY26BHoZUcO3+qFfUrqascsqbsvnCcfmp6gzjvBqcia+dIfSy7AfGn3tYpOA==" + "\n" +
            //    "Salt: " + "qfvNfOKcaKcvWqmOuMNNdw==" + "\n" +
            //    "Password is Correct: " + passIsCorrect.ToString());

            //if (Customer.CheckPassword("mei@gmail.com", "meiRinjyo"))
            //{
            //    MessageBox.Show("Login success! Password is correct!");
            //}
            //else
            //{
            //    MessageBox.Show("Login failed! Please check your email or password!");
            //}

            //Customer customer = Customer.ReadData("mei@gmail.com", "meiRinjyo");


            //MessageBox.Show("Name: " + customer.FirstName + " " + customer.LastName + "\n" +
            //    "Phone Number: " + customer.PhoneNumber + "\n" +
            //    "DOB: " + customer.DateOfBirth + "\n" +
            //    "Balance: " + customer.Balance + "\n");

            //Customer customer = new Customer("2345", "Mei", "Rinjyo", "mei@gmail.com", "1234", DateTime.Now,
            //    15000, 0, "234567", "meiRinjyo");

            //Customer.Add(customer);
            //MessageBox.Show("Customer added!");

            //Customer customer2 = new Customer("2346", "Anya", "Rinjyo", "anya@gmail.com", "1234", DateTime.Now,
            //    15000, 0, "234567", "anyaRinjyo");

            //Customer.Add(customer2);
            //MessageBox.Show("Customer added!");

            //bool isCorrect = Customer.CheckPassword("anya@gmail.com", "anyaRinjyo");
            //MessageBox.Show("The password is: " + isCorrect);

            //Customer customer = Customer.ReadData("mei@gmail.com", "meiRinjyo");
            //MessageBox.Show("Name: " + customer.FirstName + " " + customer.LastName + "\n" +
            //    "Phone Number: " + customer.PhoneNumber + "\n" +
            //    "DOB: " + customer.DateOfBirth + "\n" +
            //    "Balance: " + customer.Balance + "\n");

            //Customer customer2 = Customer.ReadData("anya@gmail.com", "anyaRinjyo");
            //MessageBox.Show("Name: " + customer2.FirstName + " " + customer2.LastName + "\n" +
            //    "Phone Number: " + customer2.PhoneNumber + "\n" +
            //    "DOB: " + customer2.DateOfBirth + "\n" +
            //    "Balance: " + customer2.Balance + "\n");

            Customer senderUser = Customer.ReadData(Customer.SearchByID("2345")
            ,"meiRinjyo");
            MessageBox.Show("Name: " + senderUser.FirstName + " " + senderUser.LastName + "\n" +
                "Phone Number: " + senderUser.PhoneNumber + "\n" +
                "DOB: " + senderUser.DateOfBirth + "\n" +
                "Balance: " + senderUser.Balance + "\n");


            //try
            //{
            //    Transaction transaction = new Transaction(1, "2345", "2346", DateTime.Now, 10000, false);
            //    bool successful = Transaction.Add(transaction, "meiRinjyo");
            //    MessageBox.Show("Transaction Successful?: " + successful);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    throw;
            //}
        }
    }
}
