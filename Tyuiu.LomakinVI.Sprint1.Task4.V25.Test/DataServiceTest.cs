using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LomakinVI.Sprint1.Task4.V25.Lib;
namespace Tyuiu.LomakinVI.Sprint1.Task4.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var a = (Math.PI) / 2;
            Assert.AreEqual(1, Math.Round(ds.Calculate(a)));
        }
    }
}
