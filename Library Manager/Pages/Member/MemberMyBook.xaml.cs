using System.Collections.ObjectModel;
using System.Data;
using System.Windows.Controls;

namespace Library_Manager.Pages.Member
{
    /// <summary>
    /// Interaction logic for MemberMyBook.xaml
    /// </summary>
    public partial class MemberMyBook : Page
    {
        public ObservableCollection<Book> books { get; set; }

        public MemberMyBook(Library_Manager.Member member)
        {
            InitializeComponent();
            books = new ObservableCollection<Book>();
            DataTable data = DataBaseManager.MyBooks(member.Id);
            for (int i = 0; i < data.Rows.Count; i++)
                books.Add(DataBaseManager.bookInfo(int.Parse(data.Rows[i][0].ToString())));

            DataContext = this;
        }
    }
}
