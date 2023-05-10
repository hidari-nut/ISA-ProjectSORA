using SORA_Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SORA_Project
{
    public partial class FormUserProfile : Form
    {
        public FormUserProfile()
        {
            InitializeComponent();
        }

        public Customer customerLogin;

        private void FormUserProfile_Load(object sender, EventArgs e)
        {
            customerLogin = Customer.ReadData(customerLogin.Email, customerLogin.Password);

            textBoxID.Text = customerLogin.Id;
            textBoxName.Text = customerLogin.FirstName + " " + customerLogin.LastName;
            textBoxEmail.Text = customerLogin.Email;
            textBoxPhone.Text = customerLogin.PhoneNumber;
            textBoxDoB.Text = customerLogin.DateOfBirth.ToString("dd/MM/yyyy");
            textBoxBalance.Text = customerLogin.Balance.ToString("C", CultureInfo.GetCultureInfo("en-US"));

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
            //    100000, 0, "234567", "meiRinjyo");

            //Customer.Add(customer);
            //MessageBox.Show("Customer added!");

            //Customer customer2 = new Customer("2346", "Anya", "Rinjyo", "anya@gmail.com", "1234", DateTime.Now,
            //    15000, 0, "234567", "anyaRinjyo");

            //Customer.Add(customer2);
            //MessageBox.Show("Customer added!");

            //bool isCorrect = Customer.CheckPassword("anya@gmail.com", "anyaRinjyo");
            //MessageBox.Show("The password is: " + isCorrect);


            //bool isCorrect = Customer.CheckPassword("mei@gmail.com", "meiRinjyo");
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

            //Customer senderUser = Customer.ReadData(Customer.SearchByID("2345")
            //, "meiRinjyo");
            //MessageBox.Show("Name: " + senderUser.FirstName + " " + senderUser.LastName + "\n" +
            //    "Phone Number: " + senderUser.PhoneNumber + "\n" +
            //    "DOB: " + senderUser.DateOfBirth + "\n" +
            //    "Balance: " + senderUser.Balance + "\n");

            //Customer senderUser = Customer.ReadData(Customer.SearchByID("2345")
            //, "meiRinjyo");
            //senderUser.Balance = 100000;
            //Customer.UpdateBalance(senderUser, "meiRinjyo");

            //try
            //{
            //    Transaction transaction = new Transaction(1, "2345", "2346", DateTime.Now, 10000, false);
            //    bool successful = Transaction.Add(transaction, "meiRinjyo");
            //    MessageBox.Show("Transaction Successful?: " + successful);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

            //bool success = Transaction.ProcessTransactions("2346", "anya@gmail.com", "anyaRinjyo");
            //MessageBox.Show("Process Completed!\n" +
            //    "Success: " + success);

            //try
            //{

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
