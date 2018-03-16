using System;
using DEV_3;
using NUnit.Framework;

namespace CalcMethod.Test
{
    [TestFixture]
    public class CalcMethodTest
    {
        [Test]
        public void ToNumberSystem_20and13_17returned()
        {
            //arrange
            string expected = "17";
            CalculationMethod cm = new CalculationMethod();
            string actual = cm.ToNumberSystem("20", "13");
            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void EmptyStringFirstTest()
        {
            //arrange
            CalculationMethod cm = new CalculationMethod();
            //assert
            Assert.IsNull(cm.ToNumberSystem(String.Empty, "13"));
        }
        [Test]
        public void EmptyStringSecondTest()
        {
            //arrange
            CalculationMethod cm = new CalculationMethod();
            //assert
            Assert.IsNull(cm.ToNumberSystem("20", String.Empty));
        }
        [Test]
        public void DataValidationStringTest()
        {
            //arrange
            CalculationMethod cm = new CalculationMethod();
            //assert
            Assert.IsNull(cm.ToNumberSystem("0", "0"));
        }
    }
}