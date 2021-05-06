using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _00_Challenges.W2D2_Calculator
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void AdditionTests()
        {
            Calculator calculator = new Calculator();

            Console.WriteLine(calculator.Addition(15, 5.1));
        }
        [TestMethod]
        public void SubtractionTests()
        {
            Calculator calculator = new Calculator();

            Console.WriteLine(calculator.Subtraction(15, 5.1));
        }
        [TestMethod]
        public void MultiplicationTests()
        {
            Calculator calculator = new Calculator();

            Console.WriteLine(calculator.Multiplication(15, 5.1));
        }
        [TestMethod]
        public void DivisionTests()
        {
            Calculator calculator = new Calculator();

            Console.WriteLine(calculator.Division(15, 5.1));
        }

        [TestMethod]
        public void DivisionReturnFractionTests()
        {
            Calculator calculator = new Calculator();

            Console.WriteLine(calculator.DivisionReturnFraction(10.5, 3));
        }

        [TestMethod]
        public void DivisionReturnPercentTests()
        {
            Calculator calculator = new Calculator();

            Console.WriteLine(calculator.DivisionReturnPercent(3, 10));
        }
    }
}
