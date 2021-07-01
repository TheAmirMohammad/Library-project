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
            memberFrame.Content = new Pages.Universal.Home("Member");
        }
        private void exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void drag(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
