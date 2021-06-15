using System.Windows;

namespace Library_Manager
{
    /// <summary>
    /// Interaction logic for MemberPanel.xaml
    /// </summary>
    public partial class MemberPanel : Window
    {
        public MemberPanel()
        {
            InitializeComponent();
        }
        private void exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
