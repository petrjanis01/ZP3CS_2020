using System;
using System.Collections.Generic;

namespace L7_Exercise_Solution
{
    public class Employee : Person
    {
        public List<Client> Clients { get; set; }

        public Employee(string name, string surname, DateTime birthDate) : base(name, surname, birthDate)
        {
            Clients = new List<Client>();
        }

        public void CreateNewClient(string clientName, string clientSurname, DateTime clientBirthDate)
        {
            var client = new Client(clientName, clientSurname, clientBirthDate);

            Clients.Add(client);
        }
    }
}
