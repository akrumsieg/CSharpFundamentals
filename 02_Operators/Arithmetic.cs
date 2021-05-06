using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _02_Operators
{
    [TestClass]
    public class Arithmetic
    {
        [TestMethod]
        public void Operators()
        {
            double a = 22;
            double b = 15;

            double sum = a + b;
            Console.WriteLine(sum);

            double difference = a - b;
            Console.WriteLine(difference);

            double product = a * b;
            Console.WriteLine(product);

            double quotient = a / b;
            Console.WriteLine(quotient);

            double remainder = a % b;
            Console.WriteLine(remainder);
        }
    }
}
