using System;
using System.Collections.Generic;
using System.Text;

namespace HW_08
{
    class Task2
    {
        public static void Str1(string str)
        {
            string str1 = "";
            string str2 = "";
            char ch = '+';
            int index = str.IndexOf(ch);
            for (int i = 0; i < str.Length; i++)
            {
                if (i < index & Char.IsNumber(str[i]))
                {
                    str1 += str[i];
                }
                else if (Char.IsNumber(str[i]))
                {
                    str2 += str[i];
                }
            }
            int number1 = Convert.ToInt32(str1);
            int number2 = Convert.ToInt32(str2);
            int sum = number1 + number2;
            Console.WriteLine(sum);
        }
    }
}