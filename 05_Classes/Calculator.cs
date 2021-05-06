using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public class Calculator
    {
        public double Addition(double numOne, double numTwo)
        {
            return numOne + numTwo;
        }

        public double Subtraction(double numOne, double numTwo)
        {
            return numOne - numTwo;
        }

        public double Division(double numOne, double numTwo)
        {
            return numOne / numTwo;
        }

        public double Multiplication(double numOne, double numTwo)
        {
            return numOne * numTwo;
        }

        public double Modulus(double numOne, double numTwo)
        {
            return numOne % numTwo;
        }

        public int CalculateAge(DateTime birthday)
        {
            TimeSpan ageSpan = DateTime.Now - birthday;
            double totalAgeInDays = ageSpan.TotalDays;
            double totalAgeInYears = totalAgeInDays / 365.25;
            int years = Convert.ToInt32(Math.Floor(totalAgeInYears));
            return years;
        }
    }
}
