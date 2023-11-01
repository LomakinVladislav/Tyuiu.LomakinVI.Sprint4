using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LomakinVI.Sprint4.Task2.V1.Lib;

namespace Tyuiu.LomakinVI.Sprint4.Task2.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] numsArray = { 2, 5, 6, 8, };

            Assert.AreEqual(96, ds.Calculate(numsArray));
        }
    }
}
