using Microsoft.VisualBasic;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Int32 a1 = 11;

            byte b = 2;
            System.Byte b1 = 3;

            char f = 'A';
            System.Char f1 = 'B';

            bool c = true;
            System.Boolean c1 = false;

            long i = 79;
            System.Int64 i1 = 56;

            short k = 15;
            System.Int16 k1 = 16;

            double e = 123.4;
            System.Double e1 = 124.5;

            decimal d = 1005.8M;
            System.Decimal d1 = 2005.8M;

            float g = 3.14F;
            System.Single g1 = 4.14F;

            object h = "Hello";
            System.Object h1 = "Bye";

            string p = "C#";
            System.String p1 = "Code";

            Console.WriteLine("a:  " + a.GetType().ToString());
            Console.WriteLine("a1: " + a1.GetType().ToString());
            Console.WriteLine("b:  " + b.GetType().ToString());
            Console.WriteLine("b1: " + b1.GetType().ToString());
            Console.WriteLine("f:  " + f.GetType().ToString());
            Console.WriteLine("f1: " + f1.GetType().ToString());
            Console.WriteLine("c:  " + c.GetType().ToString());
            Console.WriteLine("c1: " + c1.GetType().ToString());
            Console.WriteLine("i:  " + i.GetType().ToString());
            Console.WriteLine("i1: " + i1.GetType().ToString());
            Console.WriteLine("k:  " + k.GetType().ToString());
            Console.WriteLine("k1: " + k1.GetType().ToString());
            Console.WriteLine("e:  " + e.GetType().ToString());
            Console.WriteLine("e1: " + e1.GetType().ToString());
            Console.WriteLine("d:  " + d.GetType().ToString());
            Console.WriteLine("d1: " + d1.GetType().ToString());
            Console.WriteLine("g:  " + g.GetType().ToString());
            Console.WriteLine("g1: " + g1.GetType().ToString());
            Console.WriteLine("h:  " + h.GetType().ToString());
            Console.WriteLine("h1: " + h1.GetType().ToString());
            Console.WriteLine("p:  " + p.GetType().ToString());
            Console.WriteLine("p1: " + p1.GetType().ToString());
        }
    }
}
