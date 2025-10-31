using Tyuiu.KislayaVA.Sprint3.Task5.V5.Lib;

namespace Tyuiu.KislayaVA.Sprint3.Task5.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнила: Кислая В. А. | РППб25-1 ";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема:  Вложенные циклы                                                  *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнила: Кислая В. А. | РППб25-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* y = x / sin(k)                                                          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Значение переменной X = 5");
            Console.WriteLine("Начальный шаг 1 = переменая i = 1");
            Console.WriteLine("Начальный шаг 2 = переменная k = 1");
            Console.WriteLine("Конечный шаг 1 = 3");
            Console.WriteLine("Конечный шаг 2 = 10");


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            double res = ds.GetSumSumSeries(5, 1, 1, 3, 10);
            Console.WriteLine("Сумма ряда = " + res);
        }
    }
}