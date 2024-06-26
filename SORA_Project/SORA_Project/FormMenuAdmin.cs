﻿using SORA_Class;
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
    public partial class FormMenuAdmin : Form
    {
        public FormMenuAdmin()
        {
            InitializeComponent();
        }

        public Admin adminLogin;

        private void FormMenuAdmin_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome " + adminLogin.FirstName + " " + adminLogin.LastName + "!");
            textBoxName.Text = "Welcome admin Who! : who@adminSORA.id";
            textBoxName.Text = "Welcome admin " + adminLogin.FirstName + " " + adminLogin.LastName + " : " + adminLogin.Email;
        }

        private void buttonBan_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormBanAccount"];
            if (form == null)
            {
                FormBanAccount formBanAccount = new FormBanAccount();
                formBanAccount.Owner = this;
                formBanAccount.adminLogin = adminLogin;
                formBanAccount.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void buttonAccount_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormCreateAdmin"];
            if (form == null)
            {
                FormCreateAdmin formCreateAdmin = new FormCreateAdmin();
                formCreateAdmin.Owner = this;
                formCreateAdmin.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }
    }
}
