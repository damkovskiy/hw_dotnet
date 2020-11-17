using System;

namespace HW_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите номер задачи 1 / 2 / 3 / 4(сравнение реверсов)");
            int number = Convert.ToInt32(Console.ReadLine());

            switch (number)
            {
                case (1):
                    task1.array1();
                    break;

                case (2):
                    task2.array();
                    break;

                case (3):
                    task3.array();
                    break;

                case (4):
                    check.array();
                    break;
            }
        }
    }
}
