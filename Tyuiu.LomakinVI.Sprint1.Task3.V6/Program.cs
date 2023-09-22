using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.LomakinVI.Sprint1.Task3.V6.Lib;

namespace Tyuiu.LomakinVI.Sprint1.Task2.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Ломакин В. И. | ИИПб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Алгоритмы линейной структуры                                      *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Ломакин Владислав Игоревич | ИИПб-23-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу вычисления стоимости поездки на автомобиле на дачу   *");
            Console.WriteLine("* (туда и обратно). Исходными данными являются: расстояние до дачи (км);  *");
            Console.WriteLine("* количество бензина, которое потребляет автомобиль на 100 км пробега;    *");
            Console.WriteLine("* цена одного литра бензина.                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine("Введите расстояние до дачи в километрах: ");
            double distance = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите расход бензина:  ");
            double gasFlow = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите стоимость литра бензина: ");
            double gasPrice = double.Parse(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            var result = ds.TravelCost(distance, gasFlow, gasPrice);
            Console.WriteLine("Стоимость поездки =  " + result);
            Console.ReadKey();
        }
    }
}
