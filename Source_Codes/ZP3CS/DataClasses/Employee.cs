using System;

namespace DataClasses
{
    public class Employee : Person
    {
        public Position Position { get; set; }

        public string MiddleName { get; set; }

        private int _salary;
        public int Salary
        {
            // Shorter way to write: get { return _salary; }
            get => _salary;
            set
            {
                if (value < 10000)
                {
                    throw new Exception("Value for salary is below minimal salary level.");
                }
                else
                {
                    _salary = value;
                }
            }
        }

        public Employee(Position position)
        {
            Position = position;
        }

        public Employee() { }

        protected override string GetFullName()
        {
            var personName = base.GetFullName();
            return personName.Replace(" ", $" {MiddleName} ");
        }

        public override string ToString()
        {
            var nameFormatted = GetFullName();

            return $"{nameFormatted} {(BirthDate.HasValue ? BirthDate.Value.ToShortDateString() : string.Empty)} {Position}";
        }

        public override double CalculateTax()
        {
            return Salary / 100 * 15;
        }
    }
}
