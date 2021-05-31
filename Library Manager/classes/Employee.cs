using System.Collections.Generic;

namespace Library_Manager
{
    public class Employee : User
    {
        public int salary
        {
            get => default;
            set
            {
            }
        }

        public void addMember()
        {
            throw new System.NotImplementedException();
        }

        public List<Book> showAllBooks()
        {
            throw new System.NotImplementedException();
        }

        public List<Book> showBarowedBooks()
        {
            throw new System.NotImplementedException();
        }
    }
}