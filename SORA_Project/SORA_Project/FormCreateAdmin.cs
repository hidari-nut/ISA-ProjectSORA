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
    public partial class FormCreateAdmin : Form
    {
        public FormCreateAdmin()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            try
            {
                string firstName = textBoxFirstName.Text;
                string lastName = textBoxLName.Text;
                string email = textBoxEmail.Text;
                string phoneNumber = textBoxPhoneNum.Text;
                string password = textBoxPassword.Text;
                string passwordConfirm = textBoxConfirmPass.Text;
                DateTime dateOfBirth = dateTimePickerDOB.Value;

                if (password == passwordConfirm)
                {
                    string adminID = Admin.GenerateID();
                    Admin adminAdd = new Admin(adminID, firstName, lastName, email, phoneNumber,
                        dateOfBirth, password);
                    bool success = Admin.AddAdmin(adminAdd);
                    if (success)
                    {
                        MessageBox.Show("Account successfully created!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Account creation failed! Please check your data!");
                    }
                }
                else
                {
                    MessageBox.Show("Password confirm does not match your inputted password!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
