using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public abstract class Login
    {
        protected static Login user = null;
        protected string Username { get; set; }
        protected string Password { get; set; }
        protected string Name { get; set; }

        protected abstract Login GetInstance(string type);

        protected abstract Book FindBook(string bookTitle);

        protected abstract void LogOut();
    }
}
