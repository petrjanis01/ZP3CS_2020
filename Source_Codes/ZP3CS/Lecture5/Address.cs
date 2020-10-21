using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture5
{
    public class Address
    {
        public string Street { get; private set; }

        public string City { get; private set; }

        public string CityCode { get; set; }

        public string Zip { get; set; }

        public Coordinates Coordinates { get; set; }

        public Address(string street, string city)
        {
            Street = street;
            City = city;
        }

        public override string ToString()
        {
            var result = $" \n {Street}, {City} \n {CityCode}, {Zip}";
            return result;
        }
    }
}
