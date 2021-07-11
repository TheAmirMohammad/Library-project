using System.Windows;

namespace Library_Manager
{
    /// <summary>
    /// Interaction logic for EmployeePanel.xaml
    /// </summary>
    public partial class EmployeePanel : Window
    {
        Employee employee;
        public EmployeePanel(Employee emp)
        {
            InitializeComponent();
            employeeFrame.Content = new Pages.Universal.Home("Employee", emp.Name);
            employee = emp;
        }
        private void exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void log_out_btn(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
        private void drag(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void home_btn(object sender, RoutedEventArgs e)
        {
            employeeFrame.Content = new Pages.Universal.Home("Employee");
        }

        private void edit_emp_btn(object sender, RoutedEventArgs e)
        {
            employeeFrame.Content = new Pages.Employee.editEmployee(employee);
        }

        private void books_btn(object sender, RoutedEventArgs e)
        {
            employeeFrame.Content = new Pages.Employee.EmployeeBooks();
        }

        private void members_btn(object sender, RoutedEventArgs e)
        {
            employeeFrame.Content = new Pages.Universal.members(employee);
        }

        private void budget_btn(object sender, RoutedEventArgs e)
        {
            employeeFrame.Content = new Pages.Employee.wallet(employee);
        }
    }
}
