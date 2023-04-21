using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SORA_Class
{
    internal class CustomerTransaction
    {
        private Customer sender;
        private Customer recipient;
        private decimal nominal;
        private DateTime transaction_date;
        private bool indicator;
        
        internal Customer Sender { get => sender; set => sender = value; }
        internal Customer Recipient { get => recipient; set => recipient = value; }
        public decimal Nominal { get => nominal; set => nominal = value; }
        public DateTime Transaction_date { get => transaction_date; set => transaction_date = value; }
        public bool Indicator { get => indicator; set => indicator = value; }

        public CustomerTransaction(Customer sender, Customer recipient, decimal nominal, DateTime transaction_date, bool indicator)
        {
            Sender = sender;
            Recipient = recipient;
            Nominal = nominal;
            Transaction_date = transaction_date;
            Indicator = indicator;
        }

        public CustomerTransaction()
        {
            Sender = new Customer();
            Recipient = new Customer();
            Nominal = 0;
            Transaction_date = DateTime.Now;
            Indicator = false;
        }
    }
}
