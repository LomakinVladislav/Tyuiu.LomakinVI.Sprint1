using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.LomakinVI.Sprint1.Task7.V25.Lib;


namespace Tyuiu.LomakinVI.Sprint1.Task7V25
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService(); 

            Console.Title = "Спринт #1 | Выполнил: Ломакин В. И. | ИИПб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнил: Ломакин Владислав Игоревич | ИИПб-23-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение по       *");
            Console.WriteLine("* исходным значениям данных, вводимых пользователем. Ответ округлить до   *");
            Console.WriteLine("* 3 знаков после запятой.                                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*               2             3           2                               *");
            Console.WriteLine("*       x     y  + 6 + cos(x)   + xy - 2x                                 *");
            Console.WriteLine("* z = e  -   --------------------------------                             *");
            Console.WriteLine("*                       4                                                 *");
            Console.WriteLine("*                 sin(x  + 13) + 9y - 2                                   *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите число x: ");
            double x = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите число y: ");
            double y = int.Parse(Console.ReadLine());


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double z = ds.Calculate(x, y);
            Console.WriteLine("z = " + z);
            Console.ReadKey();
        }
    }
}
