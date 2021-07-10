namespace Library_Manager
{
    public class Book
    {
        string name;
        string printNumber;
        string author;
        int count;
        string genre;
        int id;
        public string Name { get => name; set => name = value; }
        public string PrintNumber { get => printNumber; set => printNumber = value; }
        public string Author { get => author; set => author = value; }
        public int Count { get => count; set => count = value; }
        public string Genre { get => genre; set => genre = value; }
        public int Id { get => id; set => id = value; }

        public Book()
        {

        }
        public Book(string Name, string Author, string Gener, string PrintNumber, int Count)
        {
            this.Name = Name;
            this.Author = Author;
            this.Genre = Gener;
            this.PrintNumber = PrintNumber;
            this.Count = Count;
        }
    }
}