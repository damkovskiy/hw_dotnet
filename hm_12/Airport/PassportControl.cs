using System;
using System.Collections.Generic;
using System.Text;

namespace Airport
{
    class PassportControl : Meeting
    {
        public PassportControl(string FirstName, string LastName, string PassportNumber)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.PassportNumber = PassportNumber;
        }

        internal void PassportCheck()
        {
            Console.WriteLine($"Добрый день {FirstName} {LastName}, номер паспорта {PassportNumber}");
            Console.WriteLine("Паспорт в порядке? Yes / No");
            string answer = Console.ReadLine();

            if (answer == "Yes")
            {
                Console.WriteLine("Хорошего полета!");
            }

            else
            {
                Console.WriteLine("У вас имеются некоторые проблемы");
            }
        }
    }
}
