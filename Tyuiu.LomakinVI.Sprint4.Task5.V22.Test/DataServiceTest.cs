using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LomakinVI.Sprint4.Task5.V22.Lib;

namespace Tyuiu.LomakinVI.Sprint4.Task5.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] testArray = new int[,] { { 0, -5, 2, -7 }, { 5, -1, 3, 0 }, { 7, -2, -11, 1 } };

            Assert.AreEqual(5, ds.Calculate(testArray));
        }
    }
}
