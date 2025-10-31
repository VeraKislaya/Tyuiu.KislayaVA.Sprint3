using Tyuiu.KislayaVA.Sprint3.Task3.V29.Lib;

namespace Tyuiu.KislayaVA.Sprint3.Task3.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            char item = 'h';
            string value = "chgr vhhtg hnht";

            string result = ds.DeleteCharInString(value, item);

            Console.Title = "Спринт #3 | Выполнила: Кислая В. А. | РППб25-1 ";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла for                                                *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнила: Кислая В. А. | РППб25-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach удалить из строки                                *");
            Console.WriteLine("* все буквы h в строке: chgr vhhtg hnht                                   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Строка: " + value);
            Console.WriteLine("Символ: " + item);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Измененная строка: " + result);
            Console.ReadKey();

        }
    }
}
