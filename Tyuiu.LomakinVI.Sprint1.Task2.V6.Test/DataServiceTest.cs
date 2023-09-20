using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LomakinVI.Sprint1.Task2.V6.Lib;

namespace Tyuiu.LomakinVI.Sprint1.Task2.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 20000;
            var result = ds.ConvertMToKm(x);
            Assert.AreEqual(20, result);
        }
    }
}
