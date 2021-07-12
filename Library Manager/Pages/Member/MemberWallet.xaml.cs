using System;
using System.Windows;
using System.Windows.Controls;

namespace Library_Manager.Pages.Member
{
    /// <summary>
    /// Interaction logic for MemberWallet.xaml
    /// </summary>
    public partial class MemberWallet : Page
    {
        int Budget;
        Library_Manager.Member member;
        public MemberWallet()
        {
            InitializeComponent();
        }
        public MemberWallet(Library_Manager.Member member)
        {
            InitializeComponent();
            this.member = member;
            UpdatePrice();
        }
        public void UpdatePrice()
        {
            Budget = DataBaseManager.MemberBalance(member.Name);
            txtBudget.Text = String.Format("{0:n0}", Budget);
        }

        private void btn_add_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (isAmountValid())
            {
                MainWindow main = new MainWindow();
                main.mainFrame.Content = new PayPanel(int.Parse(txtAmount.Text), true, member);
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
