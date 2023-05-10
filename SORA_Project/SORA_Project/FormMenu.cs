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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        public Customer customerLogin;

        private void FormMenu_Load(object sender, EventArgs e)
        {
            //Update Last login
            Customer.UpdateLastLogin(customerLogin.Id);

            //Process Transactions
            Transaction.ProcessTransactions(customerLogin.Id, customerLogin.Email, customerLogin.Password);


        }

        private void buttonAccount_Click(object sender, EventArgs e)
        {

            Form form = Application.OpenForms["FormUserProfile"];
            if (form == null)
            {
                FormUserProfile formUserProfile = new FormUserProfile();
                formUserProfile.Owner = this;
                formUserProfile.customerLogin = customerLogin;
                formUserProfile.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void buttonTransfer_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormTransfer"];
            if (form == null)
            {
                FormTransfer formTransfer = new FormTransfer();
                formTransfer.Owner = this;
                formTransfer.customerLogin = customerLogin;
                formTransfer.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }
    }
}
