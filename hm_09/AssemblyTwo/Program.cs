using AssemblyOne;
using System;

namespace AssemblyTwo
{
    class Program 
    {
        static void Main(string[] args)
        {
            Program1 program1 = new Program1();
            program1.ShowPublic();
            //program1.ShowPrivate(); метод private доступен только в том типе, где определен
            //program1.ShowInternal(); метод internal доступен только в той сборке, где определен
            //program1.ShowProtected(); данный класс не является наследником 
            //program1.ShowProtectedInternal(); данный класс не является наследником и находится в другой сборке.
            //program1.ShowProtectedPrivate(); класс находится в другой сборке.
        }
    }
}
