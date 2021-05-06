using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _05_Classes
{
    [TestClass]
    public class ClassesTests
    {
        [TestMethod]
        public void VehiclePropertiesTests()
        {
            Vehicle firstVehicle = new Vehicle();
            firstVehicle.Make = "Honda";
            firstVehicle.Model = "Accord";
            firstVehicle.Mileage = 125321.4;
            firstVehicle.TypeOfVehicle = VehicleType.Car;

            Console.WriteLine(firstVehicle.Make);
            Console.WriteLine(firstVehicle.Model);
            Console.WriteLine(firstVehicle.Mileage);
            Console.WriteLine(firstVehicle.TypeOfVehicle);
        }

        [TestMethod]
        public void VehicleMethodsTests()
        {
            Vehicle secondVehicle = new Vehicle();
            secondVehicle.TurnOn();
            Console.WriteLine(secondVehicle.IsRunning);
            secondVehicle.TurnOff();
            Console.WriteLine(secondVehicle.IsRunning);

            secondVehicle.IndicateRight();
            Console.WriteLine(secondVehicle.RightIndicator);
            Console.WriteLine(secondVehicle.LeftIndicator);
            secondVehicle.TurnOnHazards();
            Console.WriteLine(secondVehicle.RightIndicator);
            Console.WriteLine(secondVehicle.LeftIndicator);
        }

        [TestMethod]
        public void IndicatorVehicleTests()
        {
            //

            Vehicle thirdVehicle = new Vehicle();
            Indicator indicator = new Indicator();

            //Cannot be set outside of class, bc private set
            // indicator.IsFlashing = true;
            Console.WriteLine(indicator.IsFlashing);
            indicator.TurnOn();
            Console.WriteLine(indicator.IsFlashing);
        }

        [TestMethod]
        public void VehicleConstructorTests()
        {
            Vehicle car = new Vehicle();
            car.Make = "Nissan";
            car.Model = "Skyline";
            car.Mileage = 50000;
            car.TypeOfVehicle = VehicleType.Car;

            Console.WriteLine(car.Make + " " + car.Model);

            Vehicle rocket = new Vehicle("Enterprise", "Galaxy", 768887644567765.45, VehicleType.Plane);
            Console.WriteLine($"I rode on a spaceship. It was the {rocket.Make}");
        }

        //GREETER
        [TestMethod]
        public void GreeterMethodsTests()
        {
            Greeter greeterInstance = new Greeter();

            greeterInstance.SayHello("Brad");

            List<string> students = new List<string>();
            students.Add("Hannah");
            students.Add("Joel");
            students.Add("Jay");
            students.Add("Lauren");
            students.Add("Luis");

            foreach (string student in students)
            {
                greeterInstance.SayHello(student);
            }

            string greeting = greeterInstance.GetRandomGreeting();
            greeterInstance.SaySomething(greeting);
        }

        [TestMethod]
        public void CalculatorTests()
        {
            Calculator calculatorInstance = new Calculator();

            Console.WriteLine(calculatorInstance.Addition(3.7, 100));

            Console.WriteLine(calculatorInstance.CalculateAge(new DateTime(1992, 05, 12)));
        }

        [TestMethod]
        public void PersonTests()
        {
            Person firstPerson = new Person("Aaron", "Krumsieg", new DateTime(1992, 05, 12));
            Console.WriteLine(firstPerson.FirstName);
            Console.WriteLine(firstPerson.FullName);
            Console.WriteLine(firstPerson.Age);

            //why blank constructors CAN be unhelpful, missing data
            Person secondPerson = new Person();
            secondPerson.FirstName = "Joe";
            secondPerson.DateOfBirth = new DateTime(1776, 07, 04);
            Console.WriteLine(secondPerson.FullName); //prints only first name and space
            Console.WriteLine(secondPerson.Age);

            //still can change completed properties
            firstPerson.LastName = "Johnson";
            Console.WriteLine(firstPerson.FullName);

            //single statement instantiation (just another way to do it)
            Person thirdPerson = new Person()
            {
                FirstName = "Albert",
                LastName = "Einstein",
                DateOfBirth = new DateTime(1879, 03, 14)
            };

            //TESTING
            //Assert.AreEqual("Joe", secondPerson.FirstName);
            //Assert.AreNotEqual("Joe", secondPerson.FirstName);
        }

        //Within the scope of the namespace but not in scope of method - becomes a FIELD (prepend with "_")
        //a field (variable) exists at the class' global level (not a local variable)
        Person _firstPerson = new Person("Aaron", "Krumsieg", new DateTime(1992, 05, 12));


        [TestMethod]
        public void PersonTransportTest()
        {
            //accessing the Vehicle class properties through the Person class object
            _firstPerson.Transport = new Vehicle("X-Wing", "X-500", 87346128, VehicleType.Plane);
            Console.WriteLine($"{_firstPerson.FullName} drives a {_firstPerson.Transport.Make} {_firstPerson.Transport.Model}.");

            _firstPerson.Transport.Model = "T-16 Skyhopper";
            Console.WriteLine($"{_firstPerson.FullName} drives a {_firstPerson.Transport.Make} {_firstPerson.Transport.Model}.");


            Person blankPerson = new Person();
            Console.WriteLine($"Fullname: {blankPerson.FullName}");
            Console.WriteLine($"Unset class: {blankPerson.Transport}");
            Console.WriteLine($"Unset struct: {blankPerson.DateOfBirth}"); //empty struct still holds a value
            Console.WriteLine($"Age: {blankPerson.Age}"); //prints Age: 2020
        }
    }
}
