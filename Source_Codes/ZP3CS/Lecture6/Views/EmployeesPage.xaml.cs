using System.Windows.Controls;
using Lecture6.Data;
using Lecture6.Models;

namespace Lecture6.Views
{
    /// <summary>
    /// Interaction logic for EmployeesPage.xaml
    /// </summary>
    public partial class EmployeesPage : Page
    {
        public EmployeesPage()
        {
            InitializeComponent();
            var employees = DataLoader.LoadDataFromJson<Employee>("employees.json");

            ClientsControl.ItemsSource = employees;
        }
    }
}
