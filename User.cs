using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class User : Login
    {
        protected bool IsMember { get; set; } = false;

        public User()
        {

        }

        protected void ApplyForMembership()
        {
            IsMember = true;
        }
        
        protected override void LogOut()
        {
            throw new NotImplementedException();
        }

        protected override Book FindBook(string bookNamePar)
        {
            throw new NotImplementedException();
        }

        protected void BorrowBook()
        {

        }

        protected void ReturnBook()
        {

        }

        protected override Login GetInstance(string type)
        {
            throw new NotImplementedException();
        }
    }
}
