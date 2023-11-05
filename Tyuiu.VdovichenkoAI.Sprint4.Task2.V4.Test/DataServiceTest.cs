﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VdovichenkoAI.Sprint4.Task2.V4.Lib;

namespace Tyuiu.VdovichenkoAI.Sprint4.Task2.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] array = { 7, 7, 8, 8, 2, 6, 3, 3, 3, 1 };
            int res = ds.Calculate(array);
            int wait = 24;
            Assert.AreEqual(wait, res);
        }
    }
}
