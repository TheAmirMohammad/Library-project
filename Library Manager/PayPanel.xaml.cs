using System.Windows;
using System.Windows.Controls;

namespace Library_Manager
{
    /// <summary>
    /// Interaction logic for PayPanel.xaml
    /// </summary>
    public partial class PayPanel : Page
    {
        Member NewMember;
        public PayPanel()
        {
            InitializeComponent();
        }

        public PayPanel(Member MemberToAdd)
        {
            NewMember = MemberToAdd;
            InitializeComponent();
        }

        private void PayButton_Click(object sender, RoutedEventArgs e)
        {
            DataBaseManager.AddMember(NewMember);
        }
    }
}