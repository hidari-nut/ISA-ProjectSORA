using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SORA_Class
{
    internal class Product
    {
        private string id;
        private VerifiedAccount owner;
        private string name;
        private decimal price;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public decimal Price { get => price; set => price = value; }
        internal VerifiedAccount Owner { get => owner; set => owner = value; }

        public Product(string id, string name, decimal price, VerifiedAccount owner)
        {
            Id = id;
            Name = name;
            Price = price;
            Owner = owner;
        }

        public Product()
        {
            Id = "";
            Name = "";
            Price = 0;
            Owner = new VerifiedAccount();
        }
    }
}
