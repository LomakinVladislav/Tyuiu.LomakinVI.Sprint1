using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LomakinVI.Sprint1.Task7.V25.Lib;


namespace Tyuiu.LomakinVI.Sprint1.Task7.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            double x = 1; 
            double y = 2;
            double expection = 2.098;
            Assert.AreEqual(expection, ds.Calculate(x, y));
        }
    }
}
