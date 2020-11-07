using System;

namespace HW04.Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 90;
           
            for (int i = 0; i < 26; i++)
            {
                int b = a--;
                char c = Convert.ToChar(b);
                Console.WriteLine(c);
            }
        }
    }
}
