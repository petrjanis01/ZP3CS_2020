using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Controls;
using Lecture6.Data;
using Lecture6.Models;
using Newtonsoft.Json;

namespace Lecture6.Views
{
    /// <summary>
    /// Interaction logic for UsersPage.xaml
    /// </summary>
    public partial class ClientsPage : Page
    {
        public ClientsPage()
        {
            InitializeComponent();

            var clients = DataLoader.LoadDataFromJson<Client>("clients.json");

            ClientsControl.ItemsSource = clients;
        }
    }
}
