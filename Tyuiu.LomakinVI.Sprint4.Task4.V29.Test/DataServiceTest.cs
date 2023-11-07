using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LomakinVI.Sprint4.Task4.V29.Lib;

namespace Tyuiu.LomakinVI.Sprint4.Task4.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] testArray = new int[,] { { 0, 5, 2 }, { 5, 4, 3 }, { 7, 5, 1 } };

            Assert.AreEqual(6, ds.Calculate(testArray));
        }
    }
}
