using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SORA_Class;

namespace SORA_Project
{
    public partial class FormTransfer : Form
    {
        public FormTransfer()
        {
            InitializeComponent();
        }

        public Customer customerLogin;

        private void FormTransfer_Load(object sender, EventArgs e)
        {
            customerLogin = Customer.ReadData(customerLogin.Email, customerLogin.Password);
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            try
            {

                string senderID = "2345";
                string senderPass = "meiRinjyo";

                string email = textBoxOutsider.Text;
                Decimal amount = numericUpDownValue.Value;
                DateTime transactionTime = DateTime.Now;
                string transactionID = Transaction.GenerateID(transactionTime);

                string recipientID = Customer.SearchByID(email);

                Transaction transaction = new Transaction();
                if (email != "")
                {
                    transaction = new Transaction(transactionID, customerLogin.Id, recipientID, transactionTime,
                        amount, false);

                    FormConfirm formConfirm = new FormConfirm();
                    formConfirm.Owner = this;
                    formConfirm.customerLogin = customerLogin;
                    formConfirm.ongoingTransaction = transaction;
                    formConfirm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

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
        }
    }
}
