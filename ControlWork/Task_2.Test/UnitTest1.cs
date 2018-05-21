using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task_2;

namespace Task_2.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            int expected = 56;
            int width = 8; 
            int length = 7;
            AreaOfRectangle calc = new AreaOfRectangle(width, length);
            string actual = calc.Calculate(width, length);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
