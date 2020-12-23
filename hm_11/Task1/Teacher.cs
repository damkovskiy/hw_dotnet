using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Teacher : Person
    {
        private string _subject;

        public string Subject { get { return _subject; } private set { _subject = value;} }

        public void Explain()
        {
            Console.WriteLine($"Explanation {_subject} begins");
        }

        public string SetSubject(string subject)
        {
            return Subject = subject;
        }
    }
}