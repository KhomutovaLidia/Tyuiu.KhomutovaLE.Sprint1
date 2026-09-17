using Tyuiu.KhomutovaLE.Sprint1.Task5.V6.Lib;

namespace Tyuiu.KhomutovaLE.Sprint1.Task5.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Хомутова Л. Е. | РППб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Тема: Преобразование типов и класс Convert                              *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнила: Хомутова Лидия Евгеньевна | РППб-26-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Пусть k – целое от 1 до 365. Присвоить целой переменной n значение      *");
            Console.WriteLine("* 1,2,...,7 в зависимости от того, на какой день недели                   *");
            Console.WriteLine("* (понедельник, вторник,..., воскресенье) приходится k-й день             *");
            Console.WriteLine("* невисокосного года, в котором 1 января – понедельник.                   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int k;

            Console.WriteLine("Введите количество дней:");
            k = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate(k));

            Console.ReadLine();
        }
    }
}
