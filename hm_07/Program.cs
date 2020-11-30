using System;

namespace hm_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Номер задачи: 1 / 2");
            int number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case (1):
                    string str = " Любви, надежды, тихой славы; Недолго нежил нас обман,; Исчезли юные забавы,; Как сон, как утренний туман; Но в нас горит еще желанье,; Под гнетом власти роковой; Нетерпеливою душой; Отчизны внемлем призыванье.; Мы ждем с томленьем упованья; Минуты вольности святой,; Как ждет любовник молодой; Минуты верного свиданья.; Пока свободою горим,; Пока сердца для чести живы";
                    task1.array(str);
                    break;

                case (2):
                    string str1 = "Вспомнили шесть советских мультфильмов которые будет приятно пересмотреть сегодня";
                    task2.del_max(str1);
                    task2.chanching(str1);
                    task2.count(str1);
                    task2.sorting(str1);
                    break;
            }
        }
    }
}
