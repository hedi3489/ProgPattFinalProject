using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
 abstract class Login
    {
        //Protected Properties 
        protected string Username { get; set; }
        protected string Password { get; set; }
        protected string Name { get; set; }


        //Abstract Functions For The Child Classes
        protected abstract Book FindBook(string bookName);
        protected abstract void LogOut();


        //Factory Function To Instantiate a Logger
        public static Login CreateLogger(string type, string username, string password, string name, bool isMember)
        {
            Login logger = null;
            if (type == "staff")
            {
                logger = Staff.GetInstance(username, password, name);
            }
            else if (type == "user")
            {
                logger = User.GetInstance(username, password, name, isMember);
            }
            else if (type == "supplier")
            {
                logger = Supplier.GetInstance(username, password, name);
            }
            return logger;
        }
    }
}
