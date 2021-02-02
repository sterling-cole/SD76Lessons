using _05_Classes.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _05_Classes.Tests
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            // wouldnt have to do this if I made my method static,
            // I would just do Calculator.Divide(3, 5);
            Calculator calc = new Calculator();
            Console.WriteLine((3.0 / 5.0));
            Console.WriteLine(calc.Divide(3,5));


            Console.WriteLine(calc.Add("asdasdasd3.5", "asdasdasd1.7"));
        }
    }
}
