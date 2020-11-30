using System;

namespace HW04.Task7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите один из символов для движения W A S D");
            string a = Console.ReadLine();

            switch (a)
            {
                case "A":
                    Console.WriteLine("Двигаемся влево");
                    break;
                case "a":
                    Console.WriteLine("Двигаемся влево");
                    break;
                case "D":
                    Console.WriteLine("Двигаемся вправо");
                    break;
                case "d":
                    Console.WriteLine("Двигаемся вправо");
                    break;
                case "S":
                    Console.WriteLine("Двигаемся назад");
                    break;
                case "s":
                    Console.WriteLine("Двигаемся назад");
                    break;
                case "W":
                    Console.WriteLine("Двигаемся вверх");
                    break;
                case "w":
                    Console.WriteLine("Двигаемся вверх");
                    break;
                default:
                    Console.WriteLine("Стоим на месте");
                    break;
            }
        }
    }
}
