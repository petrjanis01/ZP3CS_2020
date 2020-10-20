using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture5
{
    public class Address
    {
        // TODO fill in constructor

        public string FirstName { get; set; }

        public string Surname { get; set; }

        public string Street { get; set; }

        public string City { get; set; }

        public string CityCode { get; set; }

        public string Zip { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
