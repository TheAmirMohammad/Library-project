using System.Windows;
using System.Windows.Controls;

namespace Library_Manager
{
    /// <summary>
    /// Interaction logic for LogInPage.xaml
    /// </summary>
    public partial class LogInPage : Page
    {
        public LogInPage()
        {
            InitializeComponent();
        }

        private void account_btn(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SignUpPage());
        }

        private void login_btn(object sender, RoutedEventArgs e)
        {

        }
    }
}
