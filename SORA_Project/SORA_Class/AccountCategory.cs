using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SORA_Class
{
    internal class AccountCategory
    {
        private string id;
        private string name;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }

        public AccountCategory(string id, string name)
        {
            Id = id;
            Name = name;
        }

        public AccountCategory()
        {
            Id = "";
            Name = "";
        }
    }
}
