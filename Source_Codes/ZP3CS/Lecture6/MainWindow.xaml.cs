using System.Windows;
using Lecture6.Views;

namespace Lecture6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DisplayButton_Click(object sender, RoutedEventArgs e)
        {
            if (HelloButton.IsChecked == true)
            {
                MessageBox.Show("Hello.");
            }
            else if (GoodbyeButton.IsChecked == true)
            {
                MessageBox.Show("Goodbye.");
            }
        }

        private void UsersNavigationButton_Click(object sender, RoutedEventArgs e)
        {
            // change current window to another and hide the old one
            var usersWindow = new CompanyManagementWindow();
            App.Current.MainWindow = usersWindow;
            Close();
            usersWindow.Show();
        }
    }
}
