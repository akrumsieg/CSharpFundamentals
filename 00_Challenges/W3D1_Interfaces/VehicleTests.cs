using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _00_Challenges.W3D1_Interfaces
{
    [TestClass]
    public class VehicleTests
    {
        [TestMethod]
        public void SedanTests()
        {
            Sedan accord = new Sedan("Honda", "Accord", "Red");

            Console.WriteLine(accord.TurnOn());
            Console.WriteLine(accord.Drive());
            Console.WriteLine(accord.TurnOff());
        }
    }
}
