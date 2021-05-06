using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Challenges.W1D5_StudentInstructorClasses
{
    //DECLARING ENUMS
    public enum CourseType
    {
        CyberSecurity,
        SoftwareDevelopment,
        WebDevelopment
    }

    public enum BadgeType
    {
        WhiteBadge,
        GoldBadge,
        BlueBadge,
        RedBadge
    }
    class Student
    {
        //CONSTRUCTORS
        public Student() { }
        public Student
            (
            string firstName,
            string lastName,
            DateTime dateOfBirth,
            CourseType classTaking,
            decimal balanceOwed,
            BadgeType typeOfBadge,
            bool hasGraduated
            )
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            ClassTaking = classTaking;
            BalanceOwed = balanceOwed;
            TypeOfBadge = typeOfBadge;
            HasGraduated = hasGraduated;
        }

        //PROPERTIES
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public CourseType ClassTaking { get; set; }
        public decimal BalanceOwed { get; set; }
        public BadgeType TypeOfBadge { get; set; }
        public bool HasGraduated { get; set; }

        //METHODS
        public string ReturnFullName()
        {
            return FirstName + " " + LastName;
        }

    }
}
