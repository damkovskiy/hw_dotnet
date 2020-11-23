using System;
using System.Collections.Generic;
using System.Text;

namespace HW_06
{
    public class task1
    {
        static int[] _array1 = new int[5];
        static int[] _array2 = new int[5];
        static int[] _array3 = new int[5];
        public static void array1 ()
        {
            Random rand = new Random();
            for (int i = 0; i < _array1.Length; i++)
            {
                _array1[i] = rand.Next(0, 50);
            }
            array2();
        }
        public static void array2()
        {
            for (int i = 0; i < _array2.Length; i++)
            {
                Console.WriteLine($"Введите {i+1}-ый элемент второго массива");
                int number = Convert.ToInt32(Console.ReadLine());
                _array2[i] = number;
            }
            Console.WriteLine("");
            array3();
        }
        public static void array3()
        {
            int a,b = 0;
            for (int i = 0; i < _array3.Length; i++)
            {
                a = _array1[i];
                b = _array2[i];
                _array3[i] = a + b;
            }
            show();
        }
        public static void show()
        {
            Console.WriteLine("Элементы первого массива:");
            for (int i = 0; i < _array1.Length; i++)
            {
                Console.WriteLine($"{i+1}-ый элемент: {_array1[i]}");
            }

            Console.WriteLine("");
            Console.WriteLine("Элементы второго массива:");
            for (int i = 0; i < _array2.Length; i++)
            {
                Console.WriteLine($"{i + 1}-ый элемент: {_array2[i]}");
            }
            Console.WriteLine("");
            Console.WriteLine("Элементы третьего массива(сумма первых двух):");
            for (int i = 0; i < _array3.Length; i++)
            {
                Console.WriteLine($"{i + 1}-ый элемент: {_array3[i]}");
            }
        }
    }
}
