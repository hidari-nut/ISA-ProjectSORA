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
    public partial class FormTopUpConfirmation : Form
    {
        public FormTopUpConfirmation()
        {
            InitializeComponent();
        }

        public Customer customerLogin;
        public decimal topupAmount;
        public string topupMethod;

        private void FormTopUpConfirmation_Load(object sender, EventArgs e)
        {
            textBoxEmail.Text = customerLogin.Email;
            textBoxName.Text = customerLogin.FirstName + " " + customerLogin.LastName;
            textBoxAmount.Text = topupAmount.ToString("C", CultureInfo.GetCultureInfo("en-US"));
            textBoxMethod.Text = topupMethod;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            customerLogin.Balance += topupAmount;

            bool successful = Customer.UpdateBalance(customerLogin, customerLogin.Password);
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

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
