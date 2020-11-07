using System;
using System.Collections.Generic;
using System.Text;

namespace Task3._1
{
    static class Calculator
    {
        const double Pi = 3.14;
        public static void Sum()
        {
            Console.WriteLine("Введите первое число для функции сложения");
            string a = Console.ReadLine();
            int number = int.Parse(a);

            Console.WriteLine("Введите второе число для функции сложения");
            string a1 = Console.ReadLine();
            int number1 = int.Parse(a1);

            Console.WriteLine($"Сумма равняется {number + number1}");
        }
        public static void Min()
        {
            Console.WriteLine("Введите первое число для функции вычитания");
            string a = Console.ReadLine();
            int number = int.Parse(a);

            Console.WriteLine("Введите второе число для функции вычитания");
            string a1 = Console.ReadLine();
            int number1 = int.Parse(a1);

            Console.WriteLine($"Разница равняется {number - number1}");
        }
        public static void Umn()
        {
            Console.WriteLine("Введите первое число для функции умножения");
            string a = Console.ReadLine();
            int number = int.Parse(a);

            Console.WriteLine("Введите второе число для функции умножения");
            string a1 = Console.ReadLine();
            int number1 = int.Parse(a1);

            Console.WriteLine($"Произведение равняется {number * number1}");
        }
        public static void Del()
        {
            Console.WriteLine("Введите первое число для функции деления");
            string a = Console.ReadLine();
            int number = int.Parse(a);

            Console.WriteLine("Введите второе число для функции деления");
            string a1 = Console.ReadLine();
            int number1 = int.Parse(a1);

            Console.WriteLine($"Деление равняется {number / number1}");
        }
        public static void Ost()
        {
            Console.WriteLine("Введите первое число для нахождения остатка от деления");
            string a = Console.ReadLine();
            int number = int.Parse(a);

            Console.WriteLine("Введите второе число для нахождения остатка от деления");
            string a1 = Console.ReadLine();
            int number1 = int.Parse(a1);

            Console.WriteLine($"Остаток от деления равняется {number % number1}");
        }
        public static void Krug()
        {
            Console.WriteLine("Введите число для нахождения площади круга");
            string a = Console.ReadLine();
            int number = int.Parse(a);

            Console.WriteLine($"Площадь равняется { Pi * (number * number)}");
        }
    }
}
