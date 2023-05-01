using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SORA_Class
{
    internal class Transaksi
    {
        int id;
        Customer sender;
        Customer recepient;
        DateTime transactionDate;
        double nominal;
        bool completed;

        public int Id { get => id; set => id = value; }
        public Customer Sender { get => sender; set => sender = value; }
        public Customer Recepient { get => recepient; set => recepient = value; }
        public DateTime TransactionDate { get => transactionDate; set => transactionDate = value; }
        public double Nominal { get => nominal; set => nominal = value; }
        public bool Completed { get => completed; set => completed = value; }
    }
}
