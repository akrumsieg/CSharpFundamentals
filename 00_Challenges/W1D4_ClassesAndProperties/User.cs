using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Challenges.W1D4_ClassesAndProperties
{
    class User
    {
        //BLANK CONSTRUCTOR
        public User() { }

        //FULL CONSTRUCTOR
        public User(string firstName, string lastName, int id, DateTime birthDate)
        {
            FirstName = firstName;
            LastName = lastName;
            ID = id;
            BirthDate = birthDate;
        }

        //PROPERTIES
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ID { get; }
        public DateTime BirthDate { get; set; }

        //METHODS
        public string ReturnFullName()
        {
            return (FirstName + " " + LastName);
        }

        public int ReturnAge()
        {
            TimeSpan ageSpan = DateTime.Now - BirthDate;
            double ageInDays = ageSpan.TotalDays;
            return Convert.ToInt32(Math.Floor(ageInDays / 365.25));
        }
    }
}
