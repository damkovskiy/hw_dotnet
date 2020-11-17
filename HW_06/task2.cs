using System;
using System.Collections.Generic;
using System.Text;

namespace HW_06
{
    class task2
    {
        static int[] _array = new int[6];
        static sbyte _check = 0;
        public static void array()
        {
            for (int i = 0; i < _array.Length-1; i++)
            {
                Console.WriteLine($"Введите {i + 1}-ый элемент массива");
                int number = Convert.ToInt32(Console.ReadLine());
                _array[i] = number;
            }
            Console.WriteLine("");
            show_task2();
        }
        public static void show_task2()
        {
            if (_check == 0) 
            {
                Console.WriteLine("Элементы массива:");
                for (int i = 0; i < _array.Length; i++)
                {
                    Console.WriteLine($"{i + 1}-ый элемент: {_array[i]}");
                }
                Console.WriteLine("");
                change();
            }
            else 
            {
                Console.WriteLine("Элементы измененного массива:");
                for (int i = 0; i < _array.Length; i++)
                {
                    Console.WriteLine($"{i + 1}-ый элемент: {_array[i]}");
                }
                Console.WriteLine("");
            }
        }
        public static void change()
        {
            Console.WriteLine("Введите значение n-го элемента массива");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите позицию позицию элемента от 0 до 5");
            int position = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            if (position == 5)
            {
                _array[position] = number;
            }
            else
            {
                int number2 = _array[position];
                int number3 = 0;

                for (int i = position + 1; i < _array.Length; i++)
                {
                    number3 = _array[i];
                    _array[i] = number2;
                    number2 = number3;
                }
                _array[position] = number;
            }
            _check = 1;
            show_task2();
        }
    }
}
