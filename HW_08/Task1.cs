using System;
using System.Collections.Generic;
using System.Text;

namespace HW_08
{
    class Task1
    {
       public static void Str (StringBuilder sb)
        {
            int index = 0;
            for (int i = 0; i < sb.Length; i++)
            {
                if (sb[i] != '?' & (sb[i] == '!' ^ sb[i] == '.'))
                {
                    sb.Remove(i, 1);
                    i--;
                }
                else if (sb[i] == '?')
                {
                    index = i;
                    break;
                }
            }
            for (int i = index; i < sb.Length; i++)
            {
                sb.Replace(" ", "_");
            }
            Console.WriteLine(sb);
        }
    }
}