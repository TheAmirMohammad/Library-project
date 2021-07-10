using System.Collections.ObjectModel;
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace Library_Manager.Pages.Admin
{
    /// <summary>
    /// Interaction logic for AdminBooks.xaml
    /// </summary>
    public partial class AdminBooks : Page
    {
        public ObservableCollection<Book> books { get; set; }

        AdminPanel StartWindow;
        public AdminBooks()
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

        public AdminBooks(AdminPanel StartAdminPage)
        {
            InitializeComponent();
            StartWindow = StartAdminPage;
        }

        private void AddBookButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.Universal.AddBookPage());
        }
    }
}
