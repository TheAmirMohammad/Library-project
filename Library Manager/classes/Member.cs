using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library_Manager
{
    public class Member : User
    {
        Date signDate;
        Date extensionDate;
        int remainingDays;
        List<(Book, Date)> bookList;
        string imageFileName;
        int id;
        int balance;
        public Date SignDate { get => signDate; set => signDate = value; }
        public Date ExtensionDate { get => extensionDate; set => extensionDate = value; }
        public int RemainingDays { get => remainingDays; set => remainingDays = value; }
        public List<(Book, Date)> BookList { get => bookList; set => bookList = value; }
        public string ImageFileName { get => imageFileName; set => imageFileName = value; }
        public int Id { get => id; set => id = value; }
        public int Balance { get => balance; set => balance = value; }

        public Member(string name, string phonenumber, string email, string password, Date signdate, string imageFileName, int Balance = 0) : base(name, phonenumber, email, password)
        {
            this.SignDate = signdate;
            this.ImageFileName = imageFileName;
            RemainingDays = 30;
            ExtensionDate = Date.AddDays(SignDate, RemainingDays);
            this.Balance = Balance;
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