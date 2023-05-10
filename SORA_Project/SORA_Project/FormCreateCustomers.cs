using SORA_Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SORA_Project
{
    public partial class FormCreateCustomers : Form
    {
        public FormCreateCustomers()
        {
            InitializeComponent();
        }
        private void comboBoxCountry_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void FormCreateCustomers_Load(object sender, EventArgs e)
        {

        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string firstName = textBoxFName.Text;
            string lastName = textBoxLName.Text;
            string email = textBoxEmail.Text;
            string phoneNumber = textBoxPhoneNum.Text;
            string password = textBoxPassword.Text;
            string passwordConfirm = textBoxConfirmPass.Text;
            string pin = textBoxPIN.Text;
            DateTime dateOfBirth = dateTimePickerDOB.Value;

            if (password == passwordConfirm)
            {
                string customerID = Customer.GenerateID();
                Customer customerLogin = new Customer(customerID, firstName, lastName, email, phoneNumber,
                    dateOfBirth, 0, 0, pin, password);

                MessageBox.Show("Account successfully created!");
            }
            else
            {
                MessageBox.Show("Password confirm does not match your inputted password!");
            }

            //Customer customer = new Customer("2345", "Mei", "Rinjyo", "mei@gmail.com", "1234", DateTime.Now,
            //    100000, 0, "234567", "meiRinjyo");

            //Customer.Add(customer);
            //MessageBox.Show("Customer added!");
        }
    }
}
