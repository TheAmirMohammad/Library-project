using System.Windows;

namespace Library_Manager
{
    /// <summary>
    /// Interaction logic for EmployeePanel.xaml
    /// </summary>
    public partial class EmployeePanel : Window
    {
        public EmployeePanel()
        {
            InitializeComponent();
            employeeFrame.Content = new Pages.Universal.Home("Employee");
        }
        private void exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void drag(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
