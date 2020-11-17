using System;

namespace Lecture7.DataClasses
{
    public class Order
    {
        public double Price { get; set; }

        public DateTime ProcessedDate { get; set; }

        public string Description { get; set; }

        public Order(double price, DateTime processedDate, string description)
        {
            Price = price;
            ProcessedDate = processedDate;
            Description = description;
        }
    }
}
