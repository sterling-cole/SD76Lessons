using _05_Classes.Classes;
using _06_Inheritance.People;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _05_Classes.Tests
{
    [TestClass]
    public class PersonTests
    {
        [TestMethod]
        public void NameTest()
        {
            Person person = new Person();
            person.FirstName = "Andrew";
            person.LastName = "Torr";
            person.DateOfBirth = new DateTime(1985, 9, 22);
            Console.WriteLine($"{person.FirstName} {person.LastName}, age {person.Age}");
        }

        Person otherPerson = new Person(
                "Ashley",
                "Lawrence",
                new DateTime(1989, 4, 26),
                new Vehicle()
            );

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod]
        public void MyTestMethod()
        {
            User user
        }
    }
}
