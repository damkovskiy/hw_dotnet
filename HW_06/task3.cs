using System;
using System.Collections.Generic;
using System.Text;

namespace HW_06
{
    class task3
    {
        static int[] _array = new int[7];
        public static void array()
        {
            Random rand = new Random();
            for (int i = 0; i < _array.Length; i++)
            {
                Console.WriteLine($"Введите {i + 1}-ый элемент массива");
                int number = Convert.ToInt32(Console.ReadLine());
                _array[i] = number;
            }
            Console.WriteLine("");
            reverse();
        }
        public static void reverse()
        {
            Console.WriteLine("Реверс введенного массива:");
            int end = _array.Length - 1;
            int number1 = 0;
            for (int i = 0; i < _array.Length; i++)
            {
                if (i < end)
                {
                    number1 = _array[i];
                    _array[i] = _array[end];
                    _array[end] = number1;
                    end--;
                }
                else break;
            }

            for (int i = 0; i < _array.Length; i++)
            {
                Console.WriteLine(_array[i]);
            }
        }
    }
}

        
