using System;
using System.Security.Cryptography;

namespace HW04.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер, интересующего вас метода(задания): 2 / 3");
            string metod = Console.ReadLine();
            int metod1 = int.Parse(metod);

            switch (metod1)
            {
                case 2:
                    Program.task2();
                    break;
                case 3:
                    Program.task3();
                    break;
                default:
                    Console.WriteLine("Неверный выбор - попробуйте снова");
                    break;
            }
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
        private static void task3()
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

            Console.WriteLine($"Введите результат суммы");
            string sum = Console.ReadLine();
            int sum1 = int.Parse(sum);
            int sum3 = a1 + b1;
            if (sum1 == sum3)
            {
                Console.WriteLine($"Вы верно посчитали, молодец! Сумма равняется {sum3}");
            }
            else
            {
                Console.WriteLine("Ответ неверный!");
            }
            Console.ReadKey();
        }
    }
}
