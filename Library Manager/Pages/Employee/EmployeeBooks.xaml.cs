using System.Collections.ObjectModel;
using System.Data;
using System.Windows.Controls;

namespace Library_Manager.Pages.Employee
{
    /// <summary>
    /// Interaction logic for EmployeeBooks.xaml
    /// </summary>
    public partial class EmployeeBooks : Page
    {
        public ObservableCollection<Book> books { get; set; }
        public DataTable data;

        public EmployeeBooks()
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
            data = new DataTable();
            DataContext = this;
        }

        private void Filter_Change(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (FilterChips.SelectedItem != null)
            {
                switch (FilterChips.SelectedIndex)
                {
                    case 0:
                        books.Clear();
                        data = DataBaseManager.BookList();
                        for (int i = 0; i < data.Rows.Count; i++)
                            books.Add(new Book()
                            {
                                Name = data.Rows[i][1].ToString(),
                                Author = data.Rows[i][2].ToString(),
                                Genre = data.Rows[i][3].ToString(),
                                PrintNumber = data.Rows[i][4].ToString(),
                                Count = (int)data.Rows[i][5]
                            });
                        break;
                    case 1:
                        books.Clear();
                        data = DataBaseManager.GetBorrowedBooks();
                        for (int i = 0; i < data.Rows.Count; i++)
                            books.Add(new Book()
                            {
                                Name = data.Rows[i][0].ToString(),
                                Author = data.Rows[i][1].ToString(),
                                Genre = data.Rows[i][2].ToString(),
                                PrintNumber = data.Rows[i][3].ToString(),
                                Count = (int)data.Rows[i][4]
                            });
                        break;
                    case 2:
                        books.Clear();
                        data = DataBaseManager.GetAvailableBooks();
                        for (int i = 0; i < data.Rows.Count; i++)
                            books.Add(new Book()
                            {
                                Name = data.Rows[i][0].ToString(),
                                Author = data.Rows[i][1].ToString(),
                                Genre = data.Rows[i][2].ToString(),
                                PrintNumber = data.Rows[i][3].ToString(),
                                Count = (int)data.Rows[i][4]
                            });
                        break;
                }
            }
        }
    }
}
