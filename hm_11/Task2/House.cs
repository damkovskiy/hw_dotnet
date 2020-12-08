using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class House
    {
        float _area;
        string _color;

        public float Area { get { return _area; } set { _area = value; } }
        public string Color { get { return _color; } set {_color = value; } }

        public House()
        {
            _area = 200;
            _color = "brown";
        }

        public virtual void ShowData()
        {
            Console.WriteLine($"I am a house, my area is {_area} m2");
            Console.WriteLine($"I am a door, my color is {_color}");
        }

        public string GetDoor()
        {
            return _color;
        }

        public class SmallApartment : House
        {
            public SmallApartment()
            {
                _area = 50;
            }
        }
    }
}