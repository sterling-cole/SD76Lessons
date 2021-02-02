using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _04_Loops
{
    [TestClass]
    public class Loops
    {
        [TestMethod]
        public void WhileLoops()
        {
            int total = 0;

            while (total++ < 100)
            {
                // total = total + 1;
                // total += 1;
                // total++;
                Console.WriteLine("Total: " + total);
            }

            int number = 5;
            Console.WriteLine(++number);


            Random randy = new Random();
            int someNumber = randy.Next(0, 21);

            while (true)
            {
                someNumber = randy.Next(0, 21);
                Console.WriteLine(someNumber);
                if (someNumber == 7)
                {
                    break;
                }
            }
            Console.WriteLine("out of the loop");


            // do while loops

            int i = 6;
            do
            {
                Console.WriteLine("keep going");
            } while (i < 5);
        }
        [TestMethod]
        public void ForLoops()
        {
            string greeting = "hello world!";
            foreach (char letter in greeting)
            {
                Console.WriteLine(letter);
            }

            List<string> stringList = new List<string>();
            stringList.Add("hello");
            stringList.Add("world");
            stringList.Add("banana");
            foreach (string word in stringList)
            {
                Console.WriteLine(word);
            }


            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
            }
        }

        [TestMethod]
        public void Challenge()
        {
            string poppins = "Supercalifragilisticexpialidocious.";
            foreach (char letter in poppins)
            {
                if (letter == 'i' || letter == 'l')
                {
                    Console.WriteLine(letter);
                }
                else if (letter == 'l')
                {
                   Console.WriteLine( "l");
                }


                else
                {
                    Console.WriteLine("Not an 'i'");
                }

                Console.WriteLine(poppins.Length);
                for (int i=0; poppins.Length; 1++)
                {
                    char letter = poppins[i];
                }
            }
        }
    }
}