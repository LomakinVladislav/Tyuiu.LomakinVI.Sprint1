using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LomakinVI.Sprint1.Task5.V6.Lib;

namespace Tyuiu.LomakinVI.Sprint1.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValifExpression()
        {
            DataService ds = new DataService();
            int k = 13;

            Assert.AreEqual(6, ds.Calculate(k));
        }
    }
}
