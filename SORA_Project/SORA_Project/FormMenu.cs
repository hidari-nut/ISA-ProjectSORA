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

        public Customer customerLogin = null;
        public Admin adminLogin = null;

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

        private void buttonTopup_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormTopUpCustomer"];
            if (form == null)
            {
                FormTopUpCustomer formTopUpCustomer = new FormTopUpCustomer();
                formTopUpCustomer.Owner = this;
                formTopUpCustomer.customerLogin = customerLogin;
                formTopUpCustomer.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormTransferHistory"];
            if (form == null)
            {
                FormTransferHistory formTransferHistory = new FormTransferHistory();
                formTransferHistory.Owner = this;
                formTransferHistory.customerLogin = customerLogin;
                formTransferHistory.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }
    }
}
