using System;
using System.Windows;
using System.Windows.Controls;

namespace Library_Manager.Pages.Admin
{
    /// <summary>
    /// Interaction logic for adminBank.xaml
    /// </summary>
    public partial class adminBank : Page
    {
        int Budget;
        public adminBank()
        {
            InitializeComponent();
            UpdatePrice();
        }
        public void UpdatePrice()
        {
            Budget = DataBaseManager.LibraryBudget();
            txtBudget.Text = String.Format("{0:n0}", Budget);
        }

        private void btn_add_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (txtAmount.Text != "")
            {
                DataBaseManager.AddBudget(int.Parse(txtAmount.Text));
                UpdatePrice();
            }
            else
            {
                MessageBox.Show("Put amount of Money!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
