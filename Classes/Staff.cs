using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Staff : Login
    {
        public Staff()
        {

        }

        protected override Book FindBook(string bookName)
        {
            throw new NotImplementedException();
        }

        protected override void LogOut()
        {
            throw new NotImplementedException();
        }

        private void addBook(Book bookName)
        {

        }
        private void markBook(Book bookName)
        {

        }
        private void modifyBookInfo(Book bookName)
        {

        }
        private void lendBook(Book bookName)
        {

        }
        private void addMember()
        {

        }

        protected override Login GetInstance(string type)
        {
            throw new NotImplementedException();
        }
    }
}
