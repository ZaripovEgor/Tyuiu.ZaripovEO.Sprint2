using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZaripovEO.Sprint2.Task6.V11.Lib;

namespace Tyuiu.ZaripovEO.Sprint2.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int n = 28;
            int m = 2;
            int g = 2007;
            Assert.AreEqual("Дата следующего дня: 1.3.2007", ds.FindDateOfNextDay(n, m, g));

        }
    }
}
