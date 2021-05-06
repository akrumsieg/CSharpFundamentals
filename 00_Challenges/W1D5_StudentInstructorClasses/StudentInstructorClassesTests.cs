using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _00_Challenges.W1D5_StudentInstructorClasses
{
    [TestClass]
    public class StudentInstructorClassesTests
    {
        [TestMethod]
        public void StudentClassTests()
        {
            Student student01 = new Student(
                "Aaron",
                "Krumsieg",
                new DateTime(1992, 05, 12),
                CourseType.SoftwareDevelopment,
                0,
                BadgeType.WhiteBadge,
                false);

            //Student student01 = new Student();

            //student01.FirstName = "Aaron";
            //student01.LastName = "Krumsieg";
            //student01.ClassTaking = CourseType.SoftwareDevelopment;

            Console.WriteLine(student01.ReturnFullName());
            Console.WriteLine(student01.TypeOfBadge);
        }

        [TestMethod]
        public void InstructorClassTests()
        {
        }
    }
}
