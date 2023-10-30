using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LomakinVI.Sprint4.Task0.V14.Lib;

namespace Tyuiu.LomakinVI.Sprint4.Task0.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumOddArrEl()
        {
            DataService ds = new DataService();

            int[] array = { 8, 9, 5, 4, 3, 2, 1, 0, 5, 7 };
            int summ = 30;

            Assert.AreEqual(summ, ds.GetSumOddArrEl(array));
        }
    }
}
