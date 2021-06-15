using System.Windows;
using System.Windows.Controls;

namespace Library_Manager
{
    /// <summary>
    /// Interaction logic for SignUpPage.xaml
    /// </summary>
    public partial class SignUpPage : Page
    {
        public SignUpPage()
        {
            InitializeComponent();
        }

        private void account_btn(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new LogInPage());
        }

        private void sigh_up_btn(object sender, RoutedEventArgs e)
        {

        }
    }
}
