using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SORA_Class
{
    internal class MerchantTransaction
    {
        private Customer customer;
        private Product product;
        private DateTime date;

        public DateTime Date { get => date; set => date = value; }
        internal Customer Customer { get => customer; set => customer = value; }
        internal Product Product { get => product; set => product = value; }

        public MerchantTransaction(DateTime date, Customer customer, Product product)
        {
            Date = date;
            Customer = customer;
            Product = product;
        }

        public MerchantTransaction()
        {
            Date = DateTime.Now;
            Customer = new Customer();
            Product = new Product();
        }
    }
}
