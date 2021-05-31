using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library_Manager
{
    public class Member : User
    {
        public Date signDate
        {
            get => default;
            set
            {
            }
        }

        public Date extensionDate
        {
            get => default;
            set
            {
            }
        }

        public int remainingDays
        {
            get => default;
            set
            {
            }
        }

        public List<(Book, Date)> bookList
        {
            get => default;
            set
            {
            }
        }

        public int date
        {
            get => default;
            set
            {
            }
        }

        public void borrowBook()
        {
            throw new System.NotImplementedException();
        }

        public void retrurnBook()
        {
            throw new System.NotImplementedException();
        }

        public void searchBook()
        {
            throw new System.NotImplementedException();
        }
    }
}