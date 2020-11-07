using System;

namespace HW04.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            god: 
            Console.WriteLine("Введите год вашего рождения");
                string year = Console.ReadLine();
            if (int.TryParse(year, out int year1))
            {
                
            } else
                goto god;

            mes:
            Console.WriteLine("Введите номер месяца вашего рождения");
            string month = Console.ReadLine();
            if (int.TryParse(month, out int month1))
            {

            }else
                goto mes;

            god1:
            Console.WriteLine("Введите год сегодняшнего дня");
            string year2 = Console.ReadLine();
            if (int.TryParse(year2, out int year3))
            {

            }
            else
                goto god1;

            mes1:
            Console.WriteLine("Введите номер месяца сегодняшнего дня");
            string month2 = Console.ReadLine();
            if (int.TryParse(month2, out int month3))
            {

            }
            else
                goto mes1;

            if (year1<year3 & month1<=month3)
            {
                Console.WriteLine($"Уважаемый, вам {year3-year1} лет");
            }
            else if (year1 < year3 & month1 > month3)
            {
                Console.WriteLine($"Уважаемый, вам {year3 - year1 - 1} лет");
            }
            else Console.WriteLine("Вы гость из будущего либо родились в этом году?");
        }
    }
}
