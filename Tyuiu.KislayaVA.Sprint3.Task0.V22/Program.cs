using Tyuiu.KislayaVA.Sprint3.Task0.V22.Lib;

namespace Tyuiu.KislayaVA.Sprint3.Task0.V22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            double value = 0.25;
            int startValue = 1;
            int stopValue = 8;

            Console.Title = "Спринт #3 | Выполнила: Кислая В. А. | РППб25-1 ";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла for                                                *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #22                                                             *");
            Console.WriteLine("* Выполнила: Кислая В. А. | РППб25-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл for, которая вычисляет произведение   *");
            Console.WriteLine("* ряда по формуле, при a=0,25                                             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Переменная a: " + value);
            Console.WriteLine("Старт шага:  " + startValue);
            Console.WriteLine("Конец шага: " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            var res = ds.GetMultiplySeries(value, startValue, stopValue);
            Console.WriteLine("Произведение ряда равно: " + res);
            Console.ReadKey();
        }
    }
}

