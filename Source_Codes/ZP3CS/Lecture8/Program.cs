using System;
using System.Collections.Generic;
using System.Linq;
using Lecture7.DataClasses;

namespace Lecture8
{
    class Program
    {
        // TODO re-use code from previous lecture
        static void Main(string[] args)
        {
            var customers = DataCreator.CreateCustomers();
        }

        static List<Customer> GetAllCustomersWithName(List<Customer> customers, string name)
        {
            // LINQ/extension method query
            var customersWithName = customers.Where(c => c.Name.Equals(name)).ToList();

            // for-each equivalent
            var customersWithName1 = new List<Customer>();
            foreach (var customer in customers)
            {
                if (customer.Name.Equals(name))
                {
                    customers.Add(customer);
                }
            }

            return customersWithName;
        }

        static List<Customer> GetAllCustomersWithNameSurname(List<Customer> customers, string name, string surname)
        {
            // LINQ/extension method query
            var customersWithName = customers.Where(c => c.Name.Equals(name) && c.Surname.Equals(surname)).ToList();

            // Same result but with chained extension methods.
            var customersWithName1 = customers
                .Where(c => c.Name.Equals(name))
                .Where(c => c.Surname.Equals(surname))
                .ToList();

            // for-each equivalent
            var customersWithName2 = new List<Customer>();
            foreach (var customer in customers)
            {
                if (customer.Name.Equals(name) && customer.Surname.Equals(surname))
                {
                    customers.Add(customer);
                }
            }

            return customersWithName;
        }

        static void PrintCustomers(List<Customer> customers)
        {
            customers.ForEach(c => Console.WriteLine(c.ToString()));
        }

        static int GetTotalCountOfOrders(List<Customer> customers)
        {
            var totalCount = customers.Sum(c => c.Orders.Count);

            return totalCount;
        }

        static Customer GetFirstCustomerWithOrdersCountIfExists(List<Customer> customers, int ordersCount)
        {
            var customer = customers.FirstOrDefault(c => c.Orders.Count == ordersCount);
            var customer1 = customers.Where(c => c.Orders.Count == ordersCount).FirstOrDefault();

            if (customer == null)
            {
                Console.WriteLine($"Customer with {ordersCount} orders doesn't exists");
            }

            return customer;
        }

        static Customer GetCustomerWithMostOrders(List<Customer> customers)
        {
            var mostOrdersCount = customers.Max(c => c.Orders.Count);
            var customer = customers.First(c => c.Orders.Count == mostOrdersCount);

            // TODO change this
            return customer;
        }

        static Customer GetCustomerWithLeastOrders(List<Customer> customers)
        {
            var leastOrdersCount = customers.Min(c => c.Orders.Count);
            var customer = customers.First(c => c.Orders.Count == leastOrdersCount);

            // TODO change this
            return customer;
        }

        static Customer GetCustomerWithLowestAverageOrderPrice(List<Customer> customers)
        {
            var customer = customers.OrderBy(c => c.Orders.Average(o => o.Price)).First();

            return customer;
        }

        static Customer GetCustomerWithHighestAverageOrderPrice(List<Customer> customers)
        {
            var customer = customers.OrderByDescending(c => c.Orders.Average(o => o.Price)).First();

            return customer;
        }

        static List<Customer> GetTop3SpendingCustomers(List<Customer> customers)
        {
            var topSpendingCustomers = customers.OrderByDescending(c => c.Orders.Sum(o => o.Price)).Take(3).ToList();

            return topSpendingCustomers;
        }
    }
}
