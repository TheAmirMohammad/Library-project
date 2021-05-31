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

        public List<Library_Manager.Book> showBarowedBooks()
        {
            throw new System.NotImplementedException();
        }
    }
}