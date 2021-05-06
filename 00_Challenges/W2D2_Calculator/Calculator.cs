using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Challenges.W2D2_Calculator
{
    class Calculator
    {
        //methods
        //addition
        public double Addition (double a, double b)
        {
            return a + b;
        }

        //subtraction
        public double Subtraction(double a, double b)
        {
            return a - b;
        }

        //multiplication
        public double Multiplication(double a, double b)
        {
            return a * b;
        }

        //division returning double
        public double Division(double a, double b)
        {
            return a / b;
        }

        //division returning fraction
        public string DivisionReturnFraction(double a, double b)
        {
            int wholeNum = Convert.ToInt32(Math.Floor(a / b));
            double numerator = a % b;
            double denominator = b;
            return $"{wholeNum} {numerator}/{denominator}";
        }

        //division returning percentage
        public string DivisionReturnPercent(double a, double b)
        {
            double percent = a / b * 100;
            return $"{percent}%";
        }
    }
}
