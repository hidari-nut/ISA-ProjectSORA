using SORA_Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SORA_Project
{
    public partial class FormBanAccount : Form
    {

        public FormBanAccount()
        {
            InitializeComponent();

            comboBoxAttribute.Items.Add("Not Banned");
            comboBoxAttribute.Items.Add("Banned");

            comboBoxAttribute.SelectedIndex = 0;

            customerShowBanned = false;
        }

        public Admin adminLogin;
        List<Customer> listCustomer;
        bool customerShowBanned;

        private void FormBanAccount_Load(object sender, EventArgs e)
        {
            dataGridViewInfo.Columns.Clear();
            SetDataGrid();
            listCustomer = Customer.ReadDataByAdmin(customerShowBanned);
            DisplayData();
        }

        private void buttonBan_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetDataGrid()
        {
            dataGridViewInfo.Columns.Clear();

            dataGridViewInfo.Columns.Add("idCustomer", "Customer ID");
            dataGridViewInfo.Columns.Add("email", "Customer Email");
            dataGridViewInfo.Columns.Add("banned", "Banned Status");


            dataGridViewInfo.Columns["idCustomer"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewInfo.Columns["email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewInfo.Columns["banned"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridViewInfo.AllowUserToAddRows = false;
            dataGridViewInfo.ReadOnly = true;
        }

        private void DisplayData()
        {
            dataGridViewInfo.Rows.Clear();

            if (listCustomer.Count > 0)
            {
                foreach (Customer customer in listCustomer)
                {
                    bool banned = false;
                    if (customer.Banned == 0)
                    {
                        banned = false;
                    }
                    else
                    {
                        banned = true;
                    }

                    dataGridViewInfo.Rows.Add(customer.Id, customer.Email, banned.ToString());
                }
                CreateGridButtons();
            }
        }

        private void CreateGridButtons()
        {
            if (customerShowBanned == true)
            {
                //Grid Button for Unban
                DataGridViewButtonColumn gridButton1 = new DataGridViewButtonColumn();
                gridButton1.HeaderText = "Actions";
                gridButton1.Name = "gridButtonUnban";
                gridButton1.Text = "Unban";
                gridButton1.UseColumnTextForButtonValue = true;
                dataGridViewInfo.Columns.Add(gridButton1);
            }
            else
            {
                //Grid Button for Ban
                DataGridViewButtonColumn gridButton2 = new DataGridViewButtonColumn();
                gridButton2.HeaderText = "Actions";
                gridButton2.Name = "gridButtonBan";
                gridButton2.Text = "Ban";
                gridButton2.UseColumnTextForButtonValue = true;
                dataGridViewInfo.Columns.Add(gridButton2);
            }

        }

        private void comboBoxAttribute_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxAttribute.SelectedIndex == 0)
            {
                customerShowBanned = false;
            }
            else
            {
                customerShowBanned = true;
            }
            FormBanAccount_Load(this, e);
        }

        private void dataGridViewInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string customerId = dataGridViewInfo.CurrentRow.Cells["idCustomer"].Value.ToString();
            bool isSuccessful = false;

            if (customerShowBanned == true && e.ColumnIndex == dataGridViewInfo.Columns["gridButtonUnban"].Index 
                && e.RowIndex >= 0)
            {
                isSuccessful = Customer.BanUpdate(customerId, false);

                if(isSuccessful == true)
                {
                    MessageBox.Show("Customer successfully unbanned!");
                }
                else
                {
                    MessageBox.Show("Failed to unban customer!");
                }
                FormBanAccount_Load(this, e);
            }

            if (customerShowBanned == false && e.ColumnIndex == dataGridViewInfo.Columns["gridButtonBan"].Index 
                && e.RowIndex >= 0)
            {
                isSuccessful = Customer.BanUpdate(customerId, true);

                if (isSuccessful == true)
                {
                    MessageBox.Show("Customer successfully banned!");
                }
                else
                {
                    MessageBox.Show("Failed to ban customer!");
                }
                FormBanAccount_Load(this, e);
            }
        }
    }
}
