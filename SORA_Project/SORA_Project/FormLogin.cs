using SORA_Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Helpers;
using System.Windows.Forms;

namespace SORA_Project
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void FormLogin_Load_1(object sender, EventArgs e)
        {

        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            Customer customerLogin = new Customer();

            string email = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            bool loginSuccess = Customer.CheckPassword(email, password);

            if (loginSuccess == true )
            {
                customerLogin = Customer.ReadData(email, password);
            }
            else 
            {
                MessageBox.Show("Your inputted email or password is incorrect!");
            }    
        }
    }
}
