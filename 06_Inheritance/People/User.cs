using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _06_Inheritance.People
{
    public class User
    {
        // Fields 
        private string _firstName;
        private string _lastName;

        public string ID { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public string Name
        {
            get
            {
                string fullName = $"{_firstName}{_lastName}";
                if (!string.IsNullOrWhiteSpace(fullName))
                {
                    return fullName;
                }

                return "Unnamed";

                // Same thing using a ternary example
                return !string.IsNullOrWhiteSpace(fullName) ? fullName : "Unnamed";

                // If it's sunday, isWeekend = true
                // If it's saturday isWeekend = true
                // If !isWeekend, work day!
                // This is just explaining the not "!" operation
            }
        }


        public User(string email, string userName)
        {
            Email = email;
            // setter not needed because this is a constructor
            ID = "jhbrwe";

            //Create a method that will generate a random ID
            // 16 UPPERCASE letters and numbers
            //Cannot include the letter "x"
            //Also cannot include vowels
            //Must include 1 number



            // static methods apply to the WHOLE CLASS, not any particular member
            Console.WriteLine("d");
            //Convert.ToInt32();

            // instance methods apply to PARTICULAR INSTANCE of a class
            // have to  be called from a member of the class
            Random random = new Random();
            random.Next(0, 5);


            //user.SetLastName()




        }


        // static - This applies to the whole class, not any particular member
        public static string IDMethod()
        {

            char[] letters = new char[] { 'D', 'B', 'C', 'F', 'G', '1', '2', '3', '4', '5' };
            string id = "";
            Random random = new Random();
            bool hasNumber = false;
            for (int i = 0; i < 16; i++)
            {
                Thread.Sleep(3);
                int randomNum = random.Next(0, letters.Length);
                if (i == 15 && !hasNumber)
                {
                    randomNum = random.Next(5, letters.Length);
                }
                if (randomNum >= 5)
                {
                    hasNumber = true;
                }
                id += letters[randomNum];

            }
            return id;

            // Pseudocode - breaking down your objective step-by-step, 
            // start with an empty string
            // create a random generator
            // do
            // go through positions 1 through 16
            //    pick a random letter from the array
            //    add that letter to he string 
            //while the id does not contain a loop
            // return the string

        }




        public void SetFirstName(string name)
        {
            // if name is profanity, reject it (This is why we made it a backing field)
            _firstName = name;
            // CAn't set the ID here becasue there  is no setter 
        }
        // can use the same "name" variable becasue they're in different scopes "{}"
        public void SetLastName(string name)
        {
            _lastName = name;
        }
    }
}
