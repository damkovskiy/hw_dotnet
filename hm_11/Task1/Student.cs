﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Student : Person
    {
        public void GoToClasses()
        {
            Console.WriteLine("I'm going to class");
        }

        public void ShowAge()
        {
            Console.WriteLine($"My age is: {Age} years old");
        }
    }
}