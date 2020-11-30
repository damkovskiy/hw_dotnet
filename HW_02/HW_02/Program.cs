using System;
using System.IO;

namespace HW_02
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.создаем потоковый читатель с связываем его с файлом
            // 2.считываем все данные до конца и записываем их в строку textreaderesult
            // 3.освобождаем от данных textreader
            // 4.создаем массив arrayoftextresult с типом данных string и записываем в него значения из строки textreaderesult с сохранением разделения.
            // 5.создаем массив imagebytes с типом данных byte и записываем в него значения массива arrayoftextresult
            // 6.с помощью цикла for перебираем массив imagebytes и конверитруем каждое значение из бит в байт, после чего записываем новое значение обратно в данный массив. И так пока не переберем весь массив.
            // 7.записываем получившийся массив imagebytes в новый файл с раширением .png 

            StreamReader textreader = new StreamReader(@"C:\Users\Dmitriy\Downloads\image.txt", true);
            
            string textreaderesult = textreader.ReadToEnd();

            textreader.Dispose();

            string[] arrayoftextresult = textreaderesult.Split(' ');

            byte[] imagebytes = new byte[arrayoftextresult.Length - 1];

            for (int i = 0; i < arrayoftextresult.Length - 1; i++)
            {
                byte binary = Convert.ToByte(arrayoftextresult[i], 2);
                imagebytes[i] = binary;
            }
            File.WriteAllBytes(@"C:\Users\Dmitriy\Downloads\image.png", imagebytes);
            }
    }
}
