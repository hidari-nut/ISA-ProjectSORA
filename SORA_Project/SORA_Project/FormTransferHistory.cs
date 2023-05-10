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
    public partial class FormTransferHistory : Form
    {
        public FormTransferHistory()
        {
            InitializeComponent();
        }

        public Customer customerLogin;
        List<Transaction> transactionList;

        private void FormTransferHistory_Load(object sender, EventArgs e)
        {
            SetDataGrid();
            transactionList = Transaction.ReadTransactions(customerLogin.Id, customerLogin.Email, customerLogin.Password);
            DisplayData();
        }

        private void SetDataGrid()
        {
            dataGridViewInfo.Columns.Clear();

            dataGridViewInfo.Columns.Add("transactionID", "Transaction ID");
            dataGridViewInfo.Columns.Add("sendReceive", "SEND/RECEIVE");
            dataGridViewInfo.Columns.Add("originDestination", "Origin/Destination");
            dataGridViewInfo.Columns.Add("transactionNominal", "Nominal");
            dataGridViewInfo.Columns.Add("transactionDate", "Date");

            dataGridViewInfo.Columns["transactionID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewInfo.Columns["sendReceive"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewInfo.Columns["originDestination"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewInfo.Columns["transactionNominal"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewInfo.Columns["transactionDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridViewInfo.AllowUserToAddRows = false;
            dataGridViewInfo.ReadOnly = true;
        }

        private void DisplayData()
        {
            dataGridViewInfo.Rows.Clear();

            if (transactionList.Count > 0)
            {
                foreach (Transaction transaction in transactionList)
                {                    
                    //Indicator if user is sending or receiving in the Transaction
                    string sendReceive = "";
                    //The email of the origin if the user is receiving, or the destination if the user is sending.
                    string originDestination = "";

                    if (transaction.SenderID == customerLogin.Id)
                    {
                        sendReceive = "SEND";
                        originDestination = Customer.SearchByID(transaction.RecipientID);
                    }
                    else
                    {
                        sendReceive = "RECEIVE";
                        originDestination = Customer.SearchByID(transaction.SenderID);
                    }

                    dataGridViewInfo.Rows.Add(transaction.Id, sendReceive, originDestination,
                        transaction.Nominal.ToString("C", CultureInfo.GetCultureInfo("en-US")),
                        transaction.TransactionDate.ToString());
                }
            }
        }
    }
}
