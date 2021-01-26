using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _01_TypesAndVariables
{
    [TestClass]
    public class ReferenceTypeExamples
    {
        [TestMethod]
        public void Strings()
        {
            string firstName = "Andrew";
            string lastName = "Torr";

            string concatenated = firstName + " " + lastName;

            string interpolated = $"{firstName} {lastName}";

            string composited = string.Format("{0} {1}", firstName, lastName);

            Console.WriteLine(concatenated);
            Console.WriteLine(interpolated);
            Console.WriteLine(composited);
        }

        [TestMethod]
        public void Collections()
        {
            string stringExample = "Hello World";

            string[] stringArray = { "Hello", "World", "Why", "is", "it", "always", stringExample };

            string thirdItem = stringArray[2];

            Console.WriteLine(thirdItem);

            stringArray[0] = "Hello There";
            Console.WriteLine(stringArray[0]);

            //Lists

            List<string> listOfStrings = new List<string>();

            List<int> listOfInts = new List<int>();
            listOfStrings.Add("very silly nonsense");
            listOfInts.Add(12345);
            int length = listOfStrings.Count;


            Console.WriteLine(listOfStrings[0]);
            Console.WriteLine(listOfInts[0]);

            // Queues
            Queue<string> firstInFirstOut = new Queue<string>();
            firstInFirstOut.Enqueue("I'm first");
            firstInFirstOut.Enqueue("I'm next");

            string firstItem = firstInFirstOut.Dequeue();
            Console.WriteLine(firstItem);
            Console.WriteLine(firstInFirstOut.Dequeue());


            // Dictionaries

            Dictionary<int, string> keysAndValues = new Dictionary<int, string>();

            keysAndValues.Add(5, "something");
            keysAndValues.Add(6, "something elese");
            keysAndValues[5] = "Something totally different";
            Console.WriteLine("DICTIONARY VALUE: " + keysAndValues[5]);

            Dictionary<string, decimal> importantNumbers = new Dictionary<string, decimal>();

            importantNumbers.Add("pi", 3.1415926535897m);
            importantNumbers.Add("phi", 1.681033m);
            Console.WriteLine(importantNumbers["pi"]);


            SortedList<int, string> sortedKeyAndValue = new SortedList<int, string>();
            sortedKeyAndValue.Add(13, "blah");
            HashSet<int> uniqueList = new HashSet<int>();

        }

        [TestMethod]
        public void Classes()
        {
            Random rng = new Random();

            int randomNumber = rng.Next(0, 10);

            Console.WriteLine(randomNumber);
            Console.WriteLine(rng.Next(1,10));
            Console.WriteLine(rng.Next(1,10));
        }
    }
}
