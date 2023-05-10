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
    public partial class FormPin : Form
    {
        public FormPin()
        {
            InitializeComponent();
        }

        public Customer customerLogin;
        public Transaction ongoingTransaction;

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            string pin = textBoxPIN.Text;

            string recipientID = ongoingTransaction.RecipientID;

            bool pinCorrect = Customer.CheckPin(customerLogin.Email, pin);
            if (pinCorrect)
            {
                bool successful = Transaction.Add(ongoingTransaction, customerLogin.Password);
                if (successful)
                {
                    FormTransactionSuccess formTransactionSuccess = new FormTransactionSuccess();
                    formTransactionSuccess.Owner = this.Owner;
                    formTransactionSuccess.Show();
                    this.Close();
                }
                else
                {
                    FormTransactionFailed formTransactionFailed = new FormTransactionFailed();
                    formTransactionFailed.Owner = this.Owner;
                    formTransactionFailed.Show();
                    this.Close();
                }
            }
        }
    }
}
