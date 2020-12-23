using System;
using System.Collections.Generic;
using System.Text;

namespace Airport
{
    class CheckIn : Meeting
    {
        public CheckIn(string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
        }

        internal void Check ()
        {
            Console.WriteLine("Добрый день. Ваш паспорт пожалуйста");
            Console.WriteLine("Введите ваш вариант ответа: Yes / No");
            string answer1 = Console.ReadLine();

            if (answer1 == "Yes")
            {
                Console.WriteLine("Введи номер паспорта");
                PassportNumber = Console.ReadLine();
                Console.WriteLine("Сдаете багаж?");
                Console.WriteLine("Введите ваш вариант ответа: Yes / No");
                string answer2 = Console.ReadLine();

                if (answer2 == "Yes")
                {
                    Console.WriteLine("Ставьте багаж на весы");
                }

                Console.WriteLine($"{FirstName} {LastName} ваше место номер 4А, возьмите ваши документы и проследуйте на паспортный контроль");
            }

            else
            {
                Console.WriteLine("Извините, без паспорта мы не можем вас зарегистрировать");
            }
        }
    }
}
