using System;

namespace Lecture6.Models
{
    public abstract class Person
    {
        public string FirstName { get; set; }

        public string Surname { get; set; }

        public string ImageUrl { get; set; }

        public DateTime BirthDate { get; set; }

    }
}
