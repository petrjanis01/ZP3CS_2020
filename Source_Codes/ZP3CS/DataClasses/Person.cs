using System;

namespace DataClasses
{
    public abstract class Person
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public DateTime? BirthDate { get; set; }

        protected virtual string GetFullName()
        {
            return $"{Name} {Surname}";
        }

        public override string ToString()
        {
            return GetFullName();
        }

        public abstract double CalculateTax();
    }
}
