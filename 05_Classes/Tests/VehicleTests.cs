using _05_Classes.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _05_Classes.Tests
{
    [TestClass]
    public class VehicleTests
    {
        [TestMethod]
        public void Properties()
        {
            Vehicle firstVehicle = new Vehicle();
            firstVehicle.Make = "Honda";

            Console.WriteLine(firstVehicle.Make);
            firstVehicle.Make = "CEC";
            firstVehicle.Model = "YT=1300f";
            firstVehicle.Mileage = 2400000;
            firstVehicle.Type = VehicleType.Spaceship;
        }
        [TestMethod]
        public void MyTestMethod()
        {
            Vehicle myCar = new Vehicle("Honda", "Civic", VehicleType.Car);
            Console.WriteLine(myCar.IsRunning);
            myCar.TurnOn();
            // myCar.IsRunning = false cannot be accessed
            Console.WriteLine(myCar.IsRunning);
        }
    }
}
