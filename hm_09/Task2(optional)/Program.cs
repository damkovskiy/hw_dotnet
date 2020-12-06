using System;

namespace Task2_optional_
{
    class Program
    {
        // автосвойство в отличие от полного использует для своих нужд конструктор
        
        public int PropertyFull 
        {
            get { return PropertyFull; }
            private set { PropertyFull = value; }
        }

        public int PropertyAuto { get; set; }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
