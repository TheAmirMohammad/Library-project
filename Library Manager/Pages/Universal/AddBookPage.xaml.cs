using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Library_Manager.Pages.Universal
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class AddBookPage : Page
    {
        public AddBookPage()
        {
            InitializeComponent();
        }

        private void AddBookButton_Click(object sender, RoutedEventArgs e)
        {
            if (ValidateFields())
            {
                Book NewBook = new Book(txtBookName.Text, txtBookNumber.Text, txtAuthor.Text, txtGener.Text, int.Parse(txtCount.Text));
                if (DataBaseManager.isBookExists(NewBook))
                {
                    DataBaseManager.AddBook(NewBook);
                }
            }
        }
        bool ValidateFields()
        {
            if (txtBookName.Text == "")
            {
                System.Windows.MessageBox.Show("Book name Can NOT be null!");
                return false;
            }
            if (txtAuthor.Text == "")
            {
                System.Windows.MessageBox.Show("Author Can NOT be null!");
                return false;
            }
            if (txtGener.Text == "")
            {
                System.Windows.MessageBox.Show("Gener Can NOT be null!");
                return false;
            }
            if (txtBookNumber.Text == "")
            {
                System.Windows.MessageBox.Show("Author Can NOT be null!");
                return false;
            }
            if (txtCount.Text == "")
            {
                System.Windows.MessageBox.Show("Count Can NOT be null!");
                return false;
            }
            else
            {
                try
                {
                    int.Parse(txtBookNumber.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Count is not in correct format!");
                    return false;
                }
            }
            return true;
        }
    }
}
