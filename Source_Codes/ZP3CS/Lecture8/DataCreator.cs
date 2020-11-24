using System;
using System.Collections.Generic;
using DataClasses;

namespace Lecture8
{
    public static class DataCreator
    {
        private static Random _random = new Random();

        private static readonly string[] Names = new[] { "Liam", "Noah", "William", "James", "Oliver", "Benjamin", "Lucas", "Isabella", "Sophia", "Charlotte", "Mia" };
        private static readonly string[] Surnames = new[] { "Smith", " Johnson", "Williams", "Jones", "Brown", "Davis", "Miller" };

        public static List<Customer> CreateCustomers()
        {
            var customers = new List<Customer>();
            for (var i = 0; i < 10; i++)
            {
                var customer = CreateCustomerWithOrders(Names[_random.Next(0, 11)], Surnames[_random.Next(0, 6)]);
                customers.Add(customer);
            }

            return customers;
        }

        private static Customer CreateCustomerWithOrders(string name, string surname)
        {
            var customer = new Customer
            {
                Name = name,
                Surname = surname,
                BirthDate = new DateTime(_random.Next(1950, 2000), _random.Next(1, 12), _random.Next(1, 28))
            };

            for (var i = 0; i < _random.Next(1, 30); i++)
            {
                var order = new Order(
                    _random.Next(1000, 5000),
                    new DateTime(2019, _random.Next(1, 12), _random.Next(1, 28)),
                    "some description"
                );

                customer.Orders.Add(order);
            }

            return customer;
        }
    }
}
