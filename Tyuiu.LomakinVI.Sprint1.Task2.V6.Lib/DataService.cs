using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;
using Tyuiu.LomakinVI.Sprint1.Task2.V6.Lib;


namespace Tyuiu.LomakinVI.Sprint1.Task2.V6.Lib
{
    public class DataService : ISprint1Task2V6
    {
        public double ConvertMToKm(int value)
        {
            var result = (double) value / 1000;
            return result;
        }
    }
}
