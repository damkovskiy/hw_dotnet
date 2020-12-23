using System;
using System.Collections.Generic;
using System.Text;

namespace Airport
{
    class Meeting
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public TimeSpan Time { get; set; }
        public string PassportNumber { get; set; }

        public Meeting()
        {
            Time = DateTime.Now.TimeOfDay;
        }
 
        internal void Meet()
        {
            Console.WriteLine("Добрый день! Вас приветствует аэропорт Минск-2! \nПожалуйста, представьтесь");
            Console.WriteLine("Укажите ваше имя");
            FirstName = Console.ReadLine();
            Console.WriteLine("Укажите вашу фамилию");
            LastName = Console.ReadLine();
            Console.WriteLine($"Приветсвуем Вас {FirstName} {LastName} в нашем аэропорту. Местное время: {Time}");
            Console.WriteLine("Пройдите на стойку регистрации");
        }
    }
}
