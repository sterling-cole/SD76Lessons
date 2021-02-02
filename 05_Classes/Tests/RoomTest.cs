using _05_Classes.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _05_Classes.Tests
{
    [TestClass]
    public class RoomTest
    {
        [TestMethod]
        public void Volume()
        {
            Room closet = new Room(1, 1, 3);
            Console.WriteLine("Closet volume:" + closet.Volume);
            Console.WriteLine("Closet SA: " + closet.SurfaceArea);
        }
    }
}
