using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class StudentAndTeacherTest
    {
        static void Main()
        {
            Person person = new Person();
            person.SetName("Dima");
            Console.WriteLine($"Hello all, my name is {person.Name}");
            Console.WriteLine("");

            Student student = new Student();
            student.SetName("Sam");
            student.SetAge(21);
            Console.WriteLine($"Say hello to {student.Name}");
            student.ShowAge();
            student.GoToClasses();
            Console.WriteLine("");

            Teacher teacher = new Teacher();
            teacher.SetName("Bob");
            teacher.SetSubject("Math");
            teacher.SetAge(30);
            Console.WriteLine($"Hello all. my name is {teacher.Name} and i'm your teacher");
            teacher.Explain();
        }
    }
}