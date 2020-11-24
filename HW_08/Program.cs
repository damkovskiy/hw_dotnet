using System;
using System.Text;

namespace HW_08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose task 1 / 2");
            string task = Console.ReadLine();

            switch (task)
            {
                case ("1"):
                    StringBuilder sb = new StringBuilder();
                    sb.Append("1a!2.3!!..4.!.?6 7!.. ?");
                    Task1.Str(sb);
                    break;

                case ("2"):
                    string str = "grgjj45645fef+gjgjjd2335ggg";
                    Task2.Str1(str);
                    break;

                default:
                    Task3.Str();
                    break;
            }
        }
    }
}