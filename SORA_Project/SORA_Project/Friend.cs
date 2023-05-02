using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SORA_Class
{
    internal class Friend
    {
        private Customer user;
        private Customer userFriend;
        private DateTime requestDate;

        public DateTime RequestDate { get => requestDate; set => requestDate = value; }
        internal Customer User { get => user; set => user = value; }
        internal Customer UserFriend { get => userFriend; set => userFriend = value; }

        public Friend(DateTime requestDate, Customer user, Customer userFriend)
        {
            RequestDate = requestDate;
            User = user;
            UserFriend = userFriend;
        }

        public Friend()
        {
            RequestDate = DateTime.Now;
            User = new Customer();
            UserFriend = new Customer();
        }
    }
}
