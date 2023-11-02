using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LomakinVI.Sprint4.Task3.V5.Lib;

namespace Tyuiu.LomakinVI.Sprint4.Task3.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            DataService ds = new DataService();

            int[,] testArray = new int[,] { { 0, 5, 3 }, { 5, 3, 3 }, { 7, 5, 1 } };

            Assert.AreEqual(12, ds.Calculate(testArray));
        }
    }
}
