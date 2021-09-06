using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Challenges.W3D1_Interfaces
{
    public enum VehicleType { Sedan, SUV, Truck, Motorcycle, Van}
    public interface IVehicle
    {
        //properties
        VehicleType Type { get; }
        string Make { get; }
        string Model { get; }
        string Color { get; }
        bool IsRunning { get; }
        bool IsBeingDriven { get; }

        //methods
        void TurnOn();
        void TurnOff();
        void Drive();
    }
}
