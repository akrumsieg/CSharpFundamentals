using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    class Person
    {
        //CONSTRUCTORS
        public Person() { }
        public Person(string firstName, string lastName, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }

        //PROPERTIES
        public string FirstName { get; set; }
        //backing field, last name
        private string _lastName;
        public string LastName
        {
            get
            {
                return _lastName; //returns info trom _lastName property
            }
            set
            {
                _lastName = value; //value comes from LastName, sets private field _lastName is LastName
            }
        }
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        public int Age
        {
            get
            {
                TimeSpan ageSpan = DateTime.Now - DateOfBirth;
                double totalAgeInYears = ageSpan.TotalDays / 365.25;
                int yearsOld = Convert.ToInt32(Math.Floor(totalAgeInYears));
                return yearsOld;
            }
        }
        public DateTime DateOfBirth { get; set; }
        public Vehicle Transport { get; set; } //using a class as a type within properties
    }
}
