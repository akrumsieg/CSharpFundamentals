using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public enum VehicleType {  Car, Truck, Van, Motorcycle, Plane, Boat, Scooter}
    public class Vehicle
    {
        //CONSTRUCTOR (generally goes at top of class, before properties)
        public Vehicle(string make, string model, double mileage, VehicleType typeOfVehicle)
        {
            Make = make;
            Model = model;
            Mileage = mileage;
            TypeOfVehicle = typeOfVehicle;
        }
        //another constructor, but no parameters (so that previous ClassesTests code doesn't error out
        public Vehicle() { }

        //PROPERTY
        //1 access modifier
        //2 type the property holds
        //3 name
        //4 getters and setters

        //1      2     3       4
        public string Make { get; set; }

        //more properties
        public string Model { get; set; }
        public double Mileage { get; set; }
        public VehicleType TypeOfVehicle { get; set; }

        public bool IsRunning { get; private set; }

        //methods
        public void TurnOn()
        {
            IsRunning = true;
            Console.WriteLine("You turned on the vehicle.");
        }

        public void TurnOff()
        {
            IsRunning = false;
            Console.WriteLine("You turned off the vehicle.");
        }

        //more properties
        public bool RightIndicator { get; private set; }
        public bool LeftIndicator { get; private set; }

        //more methods
        public void IndicateRight()
        {
            RightIndicator = true;
            LeftIndicator = false;
        }
        public void IndicateLeft()
        {
            RightIndicator = false;
            LeftIndicator = true;
        }
        public void TurnOnHazards()
        {
            RightIndicator = true;
            LeftIndicator = true;
        }
        public void TurnOffHazards()
        {
            RightIndicator = false;
            LeftIndicator = false;
        }
    }
    // Challenge - make indicator class - properties including IsFlashing - method for TurnOn() and TurnOff() - methods would set value of IsFlashing
    public class Indicator
    {
        public bool IsFlashing { get; private set; }

        public void TurnOn()
        {
            IsFlashing = true;
        }

        public void TurnOff()
        {
            IsFlashing = false;
        }
    }
}
