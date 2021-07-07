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

namespace Library_Manager.Pages.Admin
{
    /// <summary>
    /// Interaction logic for AdminBooks.xaml
    /// </summary>
    public partial class AdminBooks : Page
    {
        AdminPanel StartWindow;
        public AdminBooks()
        {
            InitializeComponent();
        }

        public AdminBooks(AdminPanel StartAdminPage)
        {
            InitializeComponent();
            StartWindow = StartAdminPage;
        }

        private void AddBookButton_Click(object sender, RoutedEventArgs e)
        {
            AdminPanel NewAdminPanel = new AdminPanel();
            NewAdminPanel.AdminPanelAddBookSetting();
            NewAdminPanel.Show();
            if (StartWindow != null)
            {
                StartWindow.Close();
            }
        }
    }
}
