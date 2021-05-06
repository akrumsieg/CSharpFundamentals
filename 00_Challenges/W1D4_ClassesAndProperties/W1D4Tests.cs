using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _00_Challenges.W1D4_ClassesAndProperties
{
    [TestClass]
    public class W1D4Tests
    {
        [TestMethod]
        public void UserClassTests()
        {
            //creating first instance of user class
            User firstUser = new User("Aaron", "Krumsieg", 314, new DateTime(1992, 05, 12));

            //testing with writelines
            Console.WriteLine(firstUser.BirthDate);
            Console.WriteLine($"{firstUser.ReturnFullName()} (ID#{firstUser.ID}) is {firstUser.ReturnAge()} years old.");
        }
    }
}
