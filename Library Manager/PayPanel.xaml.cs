using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
