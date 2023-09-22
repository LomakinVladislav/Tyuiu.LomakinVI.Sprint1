using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LomakinVI.Sprint1.Task3.V6.Lib;

namespace Tyuiu.LomakinVI.Sprint1.Task3.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            double distance = 67;
            double gasFlow = 8.5;
            double gasPrice = 6.5;

            Assert.AreEqual(74.035, ds.TravelCost(distance, gasFlow, gasPrice));
        }
    }
}
