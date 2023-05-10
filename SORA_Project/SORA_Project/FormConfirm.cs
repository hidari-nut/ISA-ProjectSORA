using SORA_Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SORA_Project
{
    public partial class FormConfirm : Form
    {
        public FormConfirm()
        {
            InitializeComponent();
        }

        public Customer customerLogin;
        public Transaction ongoingTransaction;

        private void FormConfirm_Load(object sender, EventArgs e)
        {
            string senderEmail = customerLogin.Email;
            string recipientEmail = Customer.SearchByID(ongoingTransaction.RecipientID);

            textBoxSender.Text = senderEmail;
            textBoxRecepient.Text = recipientEmail;
            textBoxNominal.Text = ongoingTransaction.Nominal.ToString("C", CultureInfo.GetCultureInfo("en-US"));
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            FormPin formPin = new FormPin();
            formPin.Owner = this.Owner;
            formPin.customerLogin = customerLogin;
            formPin.ongoingTransaction = ongoingTransaction;
            formPin.Show();
            this.Close();
        }
    }
}
