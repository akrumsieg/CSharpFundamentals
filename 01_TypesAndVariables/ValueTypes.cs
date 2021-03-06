using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _01_TypesAndVariables
{
    [TestClass]
    public class ValueTypes
    {
        [TestMethod]
        public void Booleans()
        {
            bool isDeclared;

            isDeclared = true;

            bool isDeclaredAndInitialized = false;
        }

        [TestMethod]
        public void Characters()
        {
            char letter = 'a';
            char numberCharacter = '7';
            char symbol = '?';
            char space = ' ';
            char specialCharacter = '\t';
        }

        [TestMethod]
        public void WholeNumbers()
        {
            byte byteExample = 255;
            short shortExample = 32767;
            Int16 anotherShortExample = 32000;
            int intMin = -2137483648;
            Int32 intMax = 2147483647;
            long longExample = 9223372036854775807;
            Int64 longMin = -9223372036854775808;
        }

        [TestMethod]
        public void Decimals()
        {
            float floatExample = 1.56495486454645486486548645864841f;
            double doubleExample = 1.56495486454645486486548645864841d;
            decimal decimalExample = 1.56495486454645486486548645864841m;

            Console.WriteLine(floatExample);
            Console.WriteLine(doubleExample);
            Console.WriteLine(decimalExample);
        }

        enum PastryType { Cake, Cupcake, Eclaire, Danish, Canoli }

        [TestMethod]
        public void Enum()
        {
            PastryType myPastry = PastryType.Eclaire;
            PastryType anotherPastry = PastryType.Danish;
        }

        [TestMethod]
        public void Structs()
        {
            DateTime today = DateTime.Today;
            Console.WriteLine(today);
            Console.WriteLine(DateTime.Now);
            DateTime birthday = new DateTime(1992, 05, 12);

            TimeSpan age = today - birthday;
            int ageInDays = age.Days;


            Console.WriteLine(ageInDays / 365);
        }
    }
}
