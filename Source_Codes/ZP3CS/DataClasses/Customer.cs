using System.Collections.Generic;

namespace DataClasses
{
    public class Customer : Person
    {
        public List<Order> Orders { get; set; }

        public Customer()
        {
            Orders = new List<Order>();
        }

        protected override string GetFullName()
        {
            return $"This is customer {Name} {Surname}";
        }

        public override double CalculateTax()
        {
            double ordersPriceSummary = 0;
            foreach (var order in Orders)
            {
                ordersPriceSummary += order.Price;
            }

            return ordersPriceSummary / 100 * 21;
        }
    }
}
