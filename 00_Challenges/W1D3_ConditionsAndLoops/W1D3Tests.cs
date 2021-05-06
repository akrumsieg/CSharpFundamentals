using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _00_Challenges.W1D3_ConditionsAndLoops
{
    [TestClass]
    public class W1D3Tests
    {
        [TestMethod]
        public void PartOne()
        {
            string super = "Supercalifragilisticexpialidocious";
            for (int i = 0; i < super.Length; i++)
            {
                Console.WriteLine(super[i]);
            }
        }

        [TestMethod]
        public void PartTwo()
        {
            string super = "Supercalifragilisticexpialidocious";
            for (int i = 0; i < super.Length; i++)
            {
                if (super[i] == 'i')
                {
                    Console.WriteLine(super[i]);
                }
                else
                {
                    Console.WriteLine("Not an i");
                }
            }
        }

        [TestMethod]
        public void BonusOne()
        {
            string super = "Supercalifragilisticexpialidocious";
            int numOfLetters = super.Length;
            Console.WriteLine($"{super} has {numOfLetters} letters.");
        }

        [TestMethod]
        public void BonusTwo()
        {
            string super = "Supercalifragilisticexpialidocious";
            for (int i = 0; i < super.Length; i++)
            {
                if (super[i] == 'i' || super[i] == 'l')
                {
                    Console.WriteLine(super[i]);
                }
                else
                {
                    Console.WriteLine("Not an i or l");
                }
            }
        }

        [TestMethod]
        public void AdditionalChallenges()
        {
            //Declare and initialize variables that hold your first name, last name, and age
            string firstName = "Aaron";
            string lastName = "Krumsieg";
            double age = 28;

            //Declare and initialize an array that holds  a collection of at least four of your favorite book or movie titles
            string[] favActivities = { "Playing trumpet", "Hunting", "Hiking", "Camping" };

            //Make a list to hold dates. Include on that list the current date and time.
            List<DateTime> dateList = new List<DateTime>()
            {
                new DateTime(1992, 05, 12),
                new DateTime(1776, 07, 04),
                DateTime.Now
            };

            foreach (DateTime thing in dateList)
            {
                Console.WriteLine(thing);
            }

            //Write out to the Console the values calculated by your age variable and the number 7.
            Console.WriteLine(age + 7);
            Console.WriteLine(age - 7);
            Console.WriteLine(age * 7);
            Console.WriteLine(age / 7);
            Console.WriteLine(age % 7);

            //Write out a collection of conditionals that evaluates a new variable for how many hours of sleep the user gets.
            double hoursOfSleep = 10.01;

            if (hoursOfSleep > 10)
            {
                Console.WriteLine("Wow that's a lot of sleep!");
            }
            else if (hoursOfSleep > 8)
            {
                Console.WriteLine("You should be pretty rested");
            }
            else if (hoursOfSleep > 4)
            {
                Console.WriteLine("Bummer");
            }
            else
            {
                Console.WriteLine("Oh man, get some sleep!");
            }

            //Write out a switch case that evaluates a variable that holds the value for how the user's day has been.
            string userInput = "Terrible";
            switch (userInput)
            {
                case "Great":
                    Console.WriteLine("That's awesome!");
                    break;
                case "Good":
                    Console.WriteLine("Glad to hear that!");
                    break;
                case "Okay":
                    Console.WriteLine("Coolio");
                    break;
                case "Bad":
                    Console.WriteLine("Hope it gets better!");
                    break;
                case ":(":
                    Console.WriteLine("Wanna talk about it?");
                    break;
                default:
                    Console.WriteLine("Big Gulps, huh? Well, see you later!!");
                    break;
            }
        }
    }
}
