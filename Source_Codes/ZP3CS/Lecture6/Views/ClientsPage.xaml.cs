using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Controls;
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

            var clients = LoadClients();

            ClientsControl.ItemsSource = clients;
        }

        public List<Client> LoadClients()
        {
            var basePath = AppContext.BaseDirectory;
            var clientsFileName = @"Data\clients.json";
            var path = Path.Combine(basePath, clientsFileName);

            var clients = new List<Client>();
            using (var sr = new StreamReader(path))
            {
                var content = sr.ReadToEnd();
                clients = JsonConvert.DeserializeObject<List<Client>>(content);
            }

            return clients;
        }

    }
}
