using System;
using System.Collections.Generic;
using System.Text;

namespace Airport 
{
    class Security : Meeting
    {
        public Security(string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
        }

        internal void Inspection ()
        {
            Console.WriteLine($"Добрый день {FirstName} {LastName}");
            Console.WriteLine("Будьте добры ваши вещи на ленту");
            Console.WriteLine("Есть при себе запрещенные предметы");
            Console.WriteLine("Введите ваш вариант ответа: Yes / No");
            string answer = Console.ReadLine();

            if (answer == "Yes")
            {
                Console.WriteLine("Пройдите пожалуйста в комнату охраны");
            }

            else
            {
                Console.WriteLine("Пройдите пожалуйста на паспортный контроль");
            }
        }
    }
}
