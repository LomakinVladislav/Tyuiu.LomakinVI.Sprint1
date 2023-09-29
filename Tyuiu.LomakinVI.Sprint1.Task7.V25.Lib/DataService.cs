using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.LomakinVI.Sprint1.Task7.V25.Lib
{
    public class DataService : ISprint1Task7V25
    {
        public double Calculate(double x, double y)
        {
            double cosinus = Math.Cos(x * x * x);
            double sinus = Math.Sin(x * x * x * x + 13);

            double result = Math.Pow(Math.E, x) - (y * y + 6 + cosinus + x * y - 2 * x * x) / (sinus + 9 * y - 2);
            return Math.Round(result, 3);
        }
    }
}
