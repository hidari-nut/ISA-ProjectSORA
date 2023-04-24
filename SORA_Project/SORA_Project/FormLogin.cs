using SORA_Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Helpers;
using System.Windows.Forms;

namespace SORA_Project
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            //(string, string) hashedPassword = Customer.SaltAndHashPassword("aPlainPassword");
            //string hashedSaltedPassword = hashedPassword.Item1;
            //string passwordSalt = hashedPassword.Item2;

            //string saltedPassword = "qfvNfOKcaKcvWqmOuMNNdw==" + "aPlainPassword";
            //bool passIsCorrect = Crypto.VerifyHashedPassword("AEjwGNVY26BHoZUcO3+qFfUrqascsqbsvnCcfmp6gzjvBqcia+dIfSy7AfGn3tYpOA==",
            //    saltedPassword);

            //MessageBox.Show("Plain password: aPlainPassword\n" +
            //    "Hashed password: " + "AEjwGNVY26BHoZUcO3+qFfUrqascsqbsvnCcfmp6gzjvBqcia+dIfSy7AfGn3tYpOA==" + "\n" +
            //    "Salt: " + "qfvNfOKcaKcvWqmOuMNNdw==" + "\n" +
            //    "Password is Correct: " + passIsCorrect.ToString());

            //Customer customer = new Customer("1234", "Monika", "Felka", "mkfelka@gmail.com", "1234", DateTime.Now,
            //    15000, false, "123456", "aPlainPassword");

            //Customer.Add(customer);
            //MessageBox.Show("Customer added!");

            if (Customer.CheckPin("mkfelka@gmail.com", "123456"))
            {
                MessageBox.Show("Login success! Password is correct!");
            }
            else
            {
                MessageBox.Show("Login failed! Please check your email or password!");
            }

        }
    }
}
