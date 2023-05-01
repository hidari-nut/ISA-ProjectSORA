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
    public partial class FormCreateCustomers : Form
    {
        public FormCreateCustomers()
        {
            InitializeComponent();
        }
        private void comboBoxCountry_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void FormCreateCustomers_Load(object sender, EventArgs e)
        {

        }
    }
}
