using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Supplier : Login
    {
        private Supplier(string username, string passwrod, string name)
        {
            Username = username;
            Password = passwrod;
            Name = name;
        }

        //public getInstance

        protected override Book FindBook(string bookName)
        {
            
        }

        protected override Login GetInstance(string type)
        {
            
        }

        protected override void LogOut()
        {

        }
    }
}
