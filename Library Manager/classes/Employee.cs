using System.Collections.Generic;

namespace Library_Manager
{
    public class Employee : User
    {
        int salary;
        int balance;
        string imageFileName;
        private string imageFile;

        public int Salary { get => salary; set => salary = value; }
        public int Balance { get => balance; set => balance = value; }
        public string ImageFileName { get => imageFileName; set => imageFileName = value; }

        public void addMember()
        {
            throw new System.NotImplementedException();
        }
        public Employee()
        {

        }
        public Employee(string name, string email, string phonenumber, string password, int salary, string imageFileName) : base(name, phonenumber, email, password)
        {
            Salary = salary;
            ImageFileName = imageFileName;
            Balance = 0;
        }

        public Employee(string name, string email, string phonenumber, string password, string imageFile) : base(name, email, phonenumber, password)
        {
            this.imageFile = imageFile;
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