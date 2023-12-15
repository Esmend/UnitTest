using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Tests
{
    [TestClass()]
    public class Class1Tests
    {
        [TestMethod()]
        public void AddTest()
        {
            double x = 10;
            double y = 20;
            double expected = 30;//всё верно

            Mylibrary m = new Mylibrary();
            double actual = m.Add(x, y);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SubtractTest()
        {
            double x = 20;
            double y = 10;
            double expected = 9;//допущена ошибка

            Mylibrary m = new Mylibrary();
            double actual = m.Subtract(x, y);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            double x = 7;
            double y = 7;
            double expected = 48;//допущена ошибка

            Mylibrary m = new Mylibrary();
            double actual = m.Multiply(x, y);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void DivideTest()
        {
            double x = 14;
            double y = 7;
            double expected = 2;//всё верно

            Mylibrary m = new Mylibrary();
            double actual = m.Divide(x, y);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void PowTest()
        {
            double x = 11;
            double y = 2;
            double expected = 121;//всё верно

            Mylibrary m = new Mylibrary();
            double actual = m.Pow(x, y);

            Assert.AreEqual(expected, actual);
        }
    }
}