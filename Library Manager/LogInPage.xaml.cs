using System.Data;
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
            DataTable empData = DataBaseManager.EmpList();
            DataTable memData = DataBaseManager.MemberList();

            string email = txtEmail.Text;
            string pass = txtPassword.Password;

            if (email == "Admin" && pass == "AdminLib123")
            {
                var admin = new AdminPanel();
                admin.Show();
                MainWindow main = Application.Current.MainWindow as MainWindow;
                if (main != null)
                {
                    main.Close();
                }
            }

            for (int i = 0; i < empData.Rows.Count; i++)
            {
                if (empData.Rows[i][2].ToString() == email && empData.Rows[i][4].ToString() == pass)
                {
                    var emp = new EmployeePanel(new Employee());
                    emp.Show();
                    MainWindow main = Application.Current.MainWindow as MainWindow;
                    if (main != null)
                    {
                        main.Close();
                    }
                }
            }

            for (int i = 0; i < memData.Rows.Count; i++)
            {
                if (memData.Rows[i][2].ToString() == email && memData.Rows[i][4].ToString() == pass)
                {
                    var emp = new MemberPanel(new Member(memData.Rows[i][1].ToString(), memData.Rows[i][3].ToString()
                                     , memData.Rows[i][2].ToString(), memData.Rows[i][4].ToString(), new Date(2000, 2, 3), memData.Rows[i][6].ToString()));
                    emp.Show();
                    MainWindow main = Application.Current.MainWindow as MainWindow;
                    if (main != null)
                    {
                        main.Close();
                    }
                }
            }
        }
    }
}
