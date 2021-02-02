﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Inheritance.People
{
    //Inheritance means we are extending another class
    // We are making another class that has the same properties, but we can add more
    class Customer : User
    {
        private int _maxID = 0;
        public int CustomerNumber { get; set; }
        public Customer(string email) : base(email, "Username")
        {
            //Random random = new Random();
            //CustomerNumber = random.Next(0, 99999999);
            //CustomerNumber = _maxId;
            _maxID++;

        } 
    }
}
