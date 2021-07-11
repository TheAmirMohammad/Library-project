using System;
using System.Collections.ObjectModel;
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace Library_Manager.Pages.Universal
{
    /// <summary>
    /// Interaction logic for employees.xaml
    /// </summary>
    public partial class employees : Page
    {
        public ObservableCollection<User> users { get; set; }
        int LibraryBudget;
        int Payment;
        AdminPanel WindowStart;
        public employees()
        {
            InitializeComponent();
            UpdatePrice();
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
        private void Fire_btn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Button btn = sender as Button;
            var obj = btn.DataContext as User;
            if (MessageBox.Show("Are you sure you want to fire " + obj.Name, "Fire employee", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                DataBaseManager.DeleteEmployee(obj.Name);
                users.Remove(obj);
                MessageBox.Show(obj.Name + " fired Successfuly!", "Fire employee", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
        public void UpdatePrice()
        {
            LibraryBudget = DataBaseManager.LibraryBudget();
            Payment = DataBaseManager.Payment();
            txtBudget.Text = "Melat Bank : $ " + String.Format("{0:n0}", LibraryBudget);
            txtpayment.Text = String.Format("{0:n0}", Payment);
        }
        private void Pay_btn_Click(object sender, RoutedEventArgs e)
        {
            if (LibraryBudget > Payment)
            {
                DataBaseManager.PayAllSalaries();
                UpdatePrice();
            }
            else
            {
                MessageBox.Show("No Enough Money!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
