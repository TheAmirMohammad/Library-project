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

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            if (isAmountValid())
            {
                MainWindow main = new MainWindow();
                main.mainFrame.Content = new PayPanel(int.Parse(txtAmount.Text));
                main.Show();

            }
        }
        bool isAmountValid()
        {
            if (string.IsNullOrEmpty(txtAmount.Text))
            {
                MessageBox.Show("Enter Amount !");
                return false;
            }
            else
            {
                if (!IsDigitsOnly(txtAmount.Text))
                {
                    MessageBox.Show("year should be all digits !");
                    return false;
                }
            }
            return true;
        }
        bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }
    }
}
