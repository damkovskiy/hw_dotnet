using System;
using System.Collections.Generic;
using System.Text;

namespace HW_15
{
    public class Motorcycle
    {
        public Guid Id { get; private set; }

        public string Name { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public int Odometer { get; set; }

        public Motorcycle(string name, string model, int year, int odometer)
        {
            Id = Guid.NewGuid();
            Name = name;
            Model = model;
            Year = year;
            Odometer = odometer;
        }

        public Motorcycle()
        {
            Id = Guid.NewGuid();
        }
    }
}
