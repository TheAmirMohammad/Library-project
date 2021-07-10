using System.Collections.ObjectModel;
using System.Data;
using System.Windows.Controls;

namespace Library_Manager.Pages.Universal
{
    /// <summary>
    /// Interaction logic for employees.xaml
    /// </summary>
    public partial class employees : Page
    {
        public ObservableCollection<User> users { get; set; }

        AdminPanel WindowStart;
        public employees()
        {
            InitializeComponent();
            users = new ObservableCollection<User>();
            DataTable data = DataBaseManager.EmpList();
            for (int i = 0; i < data.Rows.Count; i++)
                users.Add(new User() { Name = data.Rows[i][1].ToString(), Email = data.Rows[i][2].ToString(), PhoneNumber = data.Rows[i][3].ToString() });

            DataContext = this;
        }
        public employees(AdminPanel StartAdminPanel)
        {
            InitializeComponent();
            WindowStart = StartAdminPanel;
        }
        private void AddEmployeeButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddEmployee());
        }
    }
}
