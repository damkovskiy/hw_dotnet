using System;
using System.Collections.Generic;
using System.Text;

namespace HW_06
{
    class check
    {
        static ulong[] _array = new ulong[100000000];
        
        public static void array()
        {
            Random rand = new Random();
            for (int i = 0; i < _array.Length; i++)
            {
                _array[i] = (ulong)rand.Next();
            }
            my_reverse();
        }
        public static void my_reverse()
        {
            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start();
            int end = _array.Length - 1;
            ulong number1 = 0;
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
            stopwatch.Stop();
            Console.WriteLine("Время моего метода в мм: " + stopwatch.ElapsedMilliseconds);
            Console.WriteLine("");
            original_reverse();
        }
        public static void original_reverse()
        {
            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start();
            Array.Reverse(_array);
            stopwatch.Stop();
            Console.WriteLine("Время оригинального метода в мм: " + stopwatch.ElapsedMilliseconds);
        }





}
}
