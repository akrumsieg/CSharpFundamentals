using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Challenges.W3D1_Interfaces
{
    public class Sedan : IVehicle
    {
        //constructors
        public Sedan(string make, string model, string color)
        {
            Make = make;
            Model = model;
            Color = color;
        }

        //properties
        public VehicleType Type => VehicleType.Sedan;
        public string Make { get; }
        public string Model { get; }
        public string Color { get; }
        public bool IsRunning { get; private set; }
        public bool IsBeingDriven { get; private set; }

        //methods
        public void Drive()
        {
            if (!IsBeingDriven)
            {
                IsBeingDriven = true;
                Console.WriteLine("This vehicle is now being driven.");
            }
            else
            {
                Console.WriteLine("This vehicle is already being driven!");
            }
        }
        public void TurnOff()
        {
            if (IsRunning)
            {
                IsRunning = false;
                IsBeingDriven = false;
                Console.WriteLine("The vehicle is no longer running");
            }
            else
            {
                Console.WriteLine("The vehicle is already off!");
            }
        }
        public void TurnOn()
        {
            if (!IsRunning)
            {
                IsRunning = true;
                Console.WriteLine("The vehicle is now running.");
            }
            else
            {
                Console.WriteLine("The vehicle is already running!");
            }
        }
    }


    public class SUV : IVehicle
    {
        //constructors
        public SUV(string make, string model, string color)
        {
            Make = make;
            Model = model;
            Color = color;
        }

        //properties
        public VehicleType Type => VehicleType.SUV;
        public string Make { get; }
        public string Model { get; }
        public string Color { get; }
        public bool IsRunning { get; private set; }
        public bool IsBeingDriven { get; private set; }

        //methods
        public void Drive()
        {
            if (!IsBeingDriven)
            {
                IsBeingDriven = true;
                Console.WriteLine("This vehicle is now being driven.");
            }
            else
            {
                Console.WriteLine("This vehicle is already being driven!");
            }
        }
        public void TurnOff()
        {
            if (IsRunning)
            {
                IsRunning = false;
                IsBeingDriven = false;
                Console.WriteLine("The vehicle is no longer running");
            }
            else
            {
                Console.WriteLine("The vehicle is already off!");
            }
        }
        public void TurnOn()
        {
            if (!IsRunning)
            {
                IsRunning = true;
                Console.WriteLine("The vehicle is now running.");
            }
            else
            {
                Console.WriteLine("The vehicle is already running!");
            }
        }
    }

    public class Motorcycle : IVehicle
    {
        //constructors
        public Motorcycle(string make, string model, string color)
        {
            Make = make;
            Model = model;
            Color = color;
        }

        //properties
        public VehicleType Type => VehicleType.Motorcycle;
        public string Make { get; }
        public string Model { get; }
        public string Color { get; }
        public bool IsRunning { get; private set; }
        public bool IsBeingDriven { get; private set; }

        //methods
        public void Drive()
        {
            if (!IsBeingDriven)
            {
                IsBeingDriven = true;
                Console.WriteLine("This vehicle is now being driven.");
            }
            else
            {
                Console.WriteLine("This vehicle is already being driven!");
            }
        }
        public void TurnOff()
        {
            if (IsRunning)
            {
                IsRunning = false;
                IsBeingDriven = false;
                Console.WriteLine("The vehicle is no longer running");
            }
            else
            {
                Console.WriteLine("The vehicle is already off!");
            }
        }
        public void TurnOn()
        {
            if (!IsRunning)
            {
                IsRunning = true;
                Console.WriteLine("The vehicle is now running.");
            }
            else
            {
                Console.WriteLine("The vehicle is already running!");
            }
        }
    }
}
