using System;
using System.Security.Cryptography;

namespace HW04.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.task2();
        }
        private static void task2()
        {
        number1:
            Console.WriteLine("Введите первое число");
            string a = Console.ReadLine();
            if (int.TryParse(a, out int a1))
            {

            }
            else
                goto number1;

            number2:
            Console.WriteLine("Введите второе число");
            string b = Console.ReadLine();
            if (int.TryParse(b, out int b1))
            {

            }
            else
                goto number2;

            Console.WriteLine($"сумма чисел равняется {a1 + b1}");
            Console.ReadKey();
        }
    }
}
