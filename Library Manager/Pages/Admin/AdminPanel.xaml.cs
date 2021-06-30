using System.Windows;

namespace Library_Manager
{
    /// <summary>
    /// Interaction logic for AdminPanel.xaml
    /// </summary>
    public partial class AdminPanel : Window
    {
        public AdminPanel()
        {
            InitializeComponent();
            adminFrame.Content = new Pages.Universal.Home("Admin");
        }

        private void exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Drag(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
