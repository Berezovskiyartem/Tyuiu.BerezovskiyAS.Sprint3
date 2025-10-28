﻿using Tyuiu.BerezovskiyAS.Sprint3.Task2.V14.Lib;
namespace Tyuiu.BerezovskiyAS.Sprint3.Task2.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void GetMultiplySeriesTest()
        {
            DataService ds = new DataService();
            int value = 5;
            int startValue = 1;
            int stopValue = 6;

            double res = ds.GetMultiplySeries(value, startValue, stopValue);

            double wait = 10220.275;

            Assert.AreEqual(wait, res);
        }
    }
}
