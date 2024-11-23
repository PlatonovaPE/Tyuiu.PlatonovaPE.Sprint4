using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PlatonovaPE.Sprint4.Task5.V27.Lib;

namespace Tyuiu.PlatonovaPE.Sprint4.Task5.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[,] array = new int[5, 5]{ { 1, 2, -3, -5, 0 },

                                          { 0, -5, 0, 0, 0 },

                                          { 0, 2, 0, 1, 1 },

                                          { 1, -4, 0, 3, -5 },

                                          { 0, 2, 0, 1, 0 } };

            int result = ds.Calculate(array);
            int wait = 5;
            Assert.AreEqual(wait, result);
        }
    }
}