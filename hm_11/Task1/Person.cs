using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Person
    {
        private int _age;
        private string _name;

        public int Age { get { return _age;} private set { _age = value;} }
        public string Name { get { return _name; } private set { _name = value ;} }

        public int SetAge(int age)
        {
            return Age = age;
        }

        public string SetName(string name)
        {
            return Name = name;
        }
    }
}