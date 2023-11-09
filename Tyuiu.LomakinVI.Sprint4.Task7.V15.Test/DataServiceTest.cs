using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LomakinVI.Sprint4.Task7.V15.Lib;

namespace Tyuiu.LomakinVI.Sprint4.Task7.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            int n = 4;
            int m = 2;
            int[,] mtrx = new int[n, m];
            string value = "10293847";
            DataService ds = new DataService();

            Assert.AreEqual(4, ds.Calculate(n, m, value));
        }
    }
}
