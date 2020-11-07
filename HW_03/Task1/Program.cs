using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            // три варианта явного преобразования:

            int a = 4;
            byte b = (byte) a;

            long c = 25;
            int d = (int) c;

            decimal e = 135;
            double f = (double) e;

            // три примера неявного преобразования:

            byte a1 = 3;
            int b1 = a1;

            int c1 = 30;
            long d1 = c1;

            short e1 = 15;
            long f1 = e1;

            // пример операции упаковки:

            byte a2 = 6;
            object b2 = a2;

            // пример операции распаковки:

            object c2 = 3;
            int d2 = (int) c2;
        }
    }
}
