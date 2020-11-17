using System.Collections.Generic;

namespace L7_Exercise_Solution
{
    public class Bank
    {
        public List<Employee> Employees { get; set; }


        public Bank()
        {
            Employees = new List<Employee>();
        }
    }
}
