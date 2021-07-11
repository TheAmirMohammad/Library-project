using System.Collections.ObjectModel;
using System.Data;
using System.Windows.Controls;

namespace Library_Manager.Pages.Universal
{
    /// <summary>
    /// Interaction logic for members.xaml
    /// </summary>
    public partial class members : Page
    {
        Library_Manager.Employee employee;
        public ObservableCollection<User> users { get; set; }
        public members(Library_Manager.Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            users = new ObservableCollection<User>();
            DataTable data = DataBaseManager.MemberList();
            for (int i = 0; i < data.Rows.Count; i++)
                users.Add(new User() { Name = data.Rows[i][1].ToString(), Email = data.Rows[i][2].ToString(), PhoneNumber = data.Rows[i][3].ToString() });

            DataContext = this;
        }

        private void Show_info_btn(object sender, System.Windows.RoutedEventArgs e)
        {
            Button btn = sender as Button;
            var obj = btn.DataContext as Library_Manager.User;
            DataTable data = DataBaseManager.memberInfo(obj.Name);
            NavigationService.Navigate(new Pages.Member.MemberInfo(data, employee));
        }
    }
}
