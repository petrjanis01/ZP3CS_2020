using System;
using System.Collections.Generic;
using Lecture7.DataClasses;

namespace Lecture7
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee = CreateEmployee();

            Console.WriteLine(employee.ToString());
            Console.WriteLine($"Tax calculated from his salary is: {employee.CalculateTax()}");

            var customer = CreateCustomerWithOrders();

            Console.WriteLine(customer.ToString());
            Console.WriteLine($"Tax calculated from all customer's orders: {customer.CalculateTax()}");

            var people = new List<Person>();
            people.Add(employee);
            people.Add(customer);

            foreach (var person in people)
            {
                Console.WriteLine(person.ToString());
            }

            BoxingUnboxingExample(employee);
            BoxingUnboxingExample(customer);
            BoxingUnboxingExample(customer.Orders[0]);
        }

        static void BoxingUnboxingExample(object myObject)
        {
            if (myObject is Employee)
            {
                var employee = (Employee)myObject;
                Console.WriteLine($"This employee is {employee}");
            }
            else if (myObject is Order)
            {
                var order = (Order)myObject;
                Console.WriteLine($"Price of this order is {order.Price}");
            }
            else if (myObject is Customer customer)
            {
                Console.WriteLine($"This customer is {customer}");
            }
        }

        static Employee CreateEmployee()
        {
            var employee = new Employee(Position.Manager);
            employee.Name = "John";
            employee.Surname = "Doe";
            employee.MiddleName = "von";
            employee.Salary = 40000;
            employee.BirthDate = new DateTime(1990, 10, 10);

            return employee;
        }

        static Customer CreateCustomerWithOrders()
        {
            var customer = new Customer { Name = "Andy", Surname = "Jones", BirthDate = new DateTime(1989, 11, 11) };

            var random = new Random();
            for (var i = 0; i < 5; i++)
            {
                var order = new Order(
                    random.Next(1000, 5000),
                    new DateTime(2019, random.Next(1, 12), random.Next(1, 28)),
                    "some description"
                );

                customer.Orders.Add(order);
            }

            return customer;
        }
    }
}
