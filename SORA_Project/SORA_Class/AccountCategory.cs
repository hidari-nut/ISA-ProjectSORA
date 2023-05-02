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

        public static class AccountCategory
        {
            private static List<AccountCategory> accountCategories = new List<AccountCategory>();

            public static AccountCategory CreateAccountCategory(int id, string name)
            {
                AccountCategory accountCategory = new AccountCategory { Id = id, Name = name };
                accountCategories.Add(accountCategory);
                return accountCategory;
            }
        }
        public void AddAccountCategory(AccountCategory accountCategory)
        {
            accountCategories.Add(accountCategory);
        }

        //READ method
        public List<AccountCategory> GetAllAccountCategories()
        {
            return accountCategories();
        }
        public AccountCategory GetAccountCategoryId(string id)
        {
            return accountCategories.Find(AccountCategory.id == id);
        }

        public void UpdateAccountCategory(AccountCategory accountCategory)
        {
            int index = accountCategories.FindIndex(ac => ac.Id == accountCategory.Id);
            if (index >= 0)
            {
                accountCategories[index] = accountCategory;
            }
        }

        public void DeleteAccountCategory(int id)
        {
            accountCategories.RemoveAll(ac => ac.Id == id);
        }
    }
}
