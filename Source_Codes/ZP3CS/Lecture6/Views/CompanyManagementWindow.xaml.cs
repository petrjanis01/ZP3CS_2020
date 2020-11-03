using System.Windows;

namespace Lecture6.Views
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class CompanyManagementWindow : Window
    {
        public CompanyManagementWindow()
        {
            InitializeComponent();
            MainContentFrame.Content = new ClientsPage();
        }

        private void ClientMenuButton_OnClick(object sender, RoutedEventArgs e)
        {
            MainContentFrame.Content = new ClientsPage();
        }
    }
}
