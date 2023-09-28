using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LomakinVI.Sprint1.Task6.V2.Lib;

namespace Tyuiu.LomakinVI.Sprint1.Task6.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string s1 = "Hello, World!";

            Assert.AreEqual(true, ds.CheckHello(s1));
        }
    }
}
