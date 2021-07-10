using System.Collections.ObjectModel;
using System.Data;
using System.Windows.Controls;

namespace Library_Manager.Pages.Member
{
    /// <summary>
    /// Interaction logic for MemberBook.xaml
    /// </summary>
    public partial class MemberBook : Page
    {
        public ObservableCollection<Book> books { get; set; }

        public MemberBook()
        {
            InitializeComponent();
            books = new ObservableCollection<Book>();
            DataTable data = DataBaseManager.BookList();
            for (int i = 0; i < data.Rows.Count; i++)
                books.Add(new Book()
                {
                    Name = data.Rows[i][1].ToString(),
                    Author = data.Rows[i][2].ToString(),
                    Genre = data.Rows[i][3].ToString(),
                    PrintNumber = data.Rows[i][4].ToString(),
                    Count = (int)data.Rows[i][5]
                });

            DataContext = this;
        }
    }
}
