using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            House.SmallApartment smallApartment = new House.SmallApartment();
                        
            Person person = new Person();
            person.Name = "Valera";
            person.Area = smallApartment.Area;
            person.ShowData();
        }
    }
}