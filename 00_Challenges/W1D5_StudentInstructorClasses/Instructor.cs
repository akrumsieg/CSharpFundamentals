using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Challenges.W1D5_StudentInstructorClasses
{
    //enums are declared in student.cs
    class Instructor
    {

        //CONSTRUCTORS
        public Instructor (int employeeNumber) { EmployeeNumber = employeeNumber; }
        public Instructor
            (
            string firstName,
            string lastName,
            DateTime dateOfBirth,
            int employeeNumber,
            CourseType classTeaching
            )
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            EmployeeNumber = employeeNumber;
            ClassTeaching = classTeaching;
        }


        //PROPERTIES
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int EmployeeNumber { get; }
        public CourseType ClassTeaching { get; set; }

        //METHODS
        public string ReturnFullName()
        {
            return FirstName + " " + LastName;
        }


    }
}
