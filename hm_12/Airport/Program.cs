using System;

namespace Airport
{
    class Program
    {
        static void Main(string[] args)
        {
            Meeting meeting = new Meeting();
            meeting.Meet();

            CheckIn checkIn = new CheckIn(meeting.FirstName, meeting.LastName);
            checkIn.Check();

            int SecurityControl = 0;
            if (checkIn.PassportNumber != null)
            {
                Security security = new Security(meeting.FirstName, meeting.LastName);
                security.Inspection();
                SecurityControl = 1;
            }

            else
            {
                Console.WriteLine("Вы не прошли регистрацию. До свидания");
            }

            if (SecurityControl == 1)
            {
                PassportControl passportControl = new PassportControl(meeting.FirstName, meeting.LastName, checkIn.PassportNumber);
                passportControl.PassportCheck();
            }
        }
    }
}
