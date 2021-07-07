using System.Windows.Controls;

namespace Library_Manager.Pages.Universal
{
    /// <summary>
    /// Interaction logic for employees.xaml
    /// </summary>
    public partial class employees : Page
    {
        AdminPanel WindowStart;
        public employees()
        {
            InitializeComponent();
        }
        public employees(AdminPanel StartAdminPanel)
        {
            InitializeComponent();
            WindowStart = StartAdminPanel;
        }
        private void AddEmployeeButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            AdminPanel NewAdminPanel = new AdminPanel();
            NewAdminPanel.AdminPanelAddEmployeeSetting();
            NewAdminPanel.Show();
            if (WindowStart != null)
            {
                WindowStart.Close();
            }
        }
    }
}
