using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Person : House
    {
        string _name;

        public string Name { get { return _name; } set { _name = value; } }

        public override void ShowData()
        {
            Console.WriteLine(_name);
            base.ShowData();
        }
    }
}