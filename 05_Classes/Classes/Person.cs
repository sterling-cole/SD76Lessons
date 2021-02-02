using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes.Classes
{
    public class Person
    {
        // The usual order, usual organization
        //Fields
        //Properties
        //Constructors
        //Methods


        // Properties
        // - tend to be accessible from outside
        // - use Pascal case
        public string FirstName { get; set; }
        //Fields
        // - tend to be private, only apply to the class within
        // - use an undescore and Camel Case

        // Backing field - because it goes with a property
        // holds the value
        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string FullName
        {
            get {
                return $"{FirstName} {LastName}";
                 }
        }

        public DateTime DateOfBirth { get; set; }

        public int Age
        {
            get
            {
                TimeSpan ageSpan = DateTime.Now - DateOfBirth;
                double totalAgeInYears = ageSpan.TotalDays / 365.241;
                int yearsOfAge = Convert.ToInt32(totalAgeInYears);
                return yearsOfAge;
            }
        }

        public Vehicle Vehicle { get; set; }


        // Empty Constructor
        public Person() { }

        //Full Constructor (overload)

        public Person(string firstName, string lastName, DateTime dob, Vehicle vehicle)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dob;
            Vehicle = vehicle;
        }

        public void SayHello()
        {
            Console.WriteLine($"{FullName} says 'Hello'");
        }

    }
}
