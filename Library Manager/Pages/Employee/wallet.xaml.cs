using System;
using System.Windows.Controls;

namespace Library_Manager.Pages.Employee
{
    /// <summary>
    /// Interaction logic for wallet.xaml
    /// </summary>
    public partial class wallet : Page
    {
        Library_Manager.Employee CurrentEmployee;
        int Budget;
        public wallet()
        {
            InitializeComponent();
        }
        public wallet (Library_Manager.Employee employee)
        {
            InitializeComponent();
            CurrentEmployee = employee;
            UpdatePrice();
        }
        public void UpdatePrice()
        {
            Budget = DataBaseManager.BalanceEmployee(CurrentEmployee.Name);
            txtBudget.Text = String.Format("{0:n0}", Budget);
        }
    }
}
