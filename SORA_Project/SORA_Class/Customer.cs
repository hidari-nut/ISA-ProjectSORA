using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SORA_Class
{
    internal class Customer
    {
        private string id;
        private string firstName;
        private string lastName;
        private string email;
        private string phoneNumber;
        private DateTime dateOfBirth;
        private decimal balance;
        private bool banned;

        public string Id { get => id; set => id = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Email { get => email; set => email = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public decimal Balance { get => balance; set => balance = value; }
        public bool Banned { get => banned; set => banned = value; }

        public Customer(string id, string firstName, string lastName, string email, string phoneNumber, 
            DateTime dateOfBirth, decimal balance, bool banned)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            DateOfBirth = dateOfBirth;
            Balance = balance;
            Banned = banned;
        }

        public Customer()
        {
            Id = "";
            FirstName = "";
            LastName = "";
            Email = "";
            PhoneNumber = "";
            DateOfBirth = DateTime.Now;
            Balance = 0;
            Banned = false;
        }
    }
}
