using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EveryDay.Calc.Calculation;

namespace UnitTest
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void TestSum()
        {
            // Arrange
            var calc = new Calculator();
            
            // Act
            var sum = calc.Sum(1, 2);
            var sum1 = calc.Sum(0, 0);
            var sum2 = calc.Sum(1, -1);

            // Assert
            Assert.AreEqual(3, sum);
            Assert.AreEqual(0, sum1);
            Assert.AreEqual(0, sum2);
        }

        [TestMethod]
        public void TestDiv()
        {
            // Arrange
            var calc = new Calculator();

            // Act
            var div  = calc.Div(2, 1);
            var div1 = calc.Div(0, 0);
            var div2 = calc.Div(1, -1);

            // Assert
            Assert.AreEqual(2, div);
            Assert.AreEqual(0, div1);
            Assert.AreEqual(-1, div2);
        }

        [TestMethod]
        public void TestSubstr()
        {
            // Arrange
            var calc = new Calculator();

            // Act
            var div = calc.Substr(2, 1);
            var div1 = calc.Substr(0, 0);
            var div2 = calc.Substr(1, -1);

            // Assert
            Assert.AreEqual(1, div);
            Assert.AreEqual(0, div1);
            Assert.AreEqual(2, div2);
        }

        [TestMethod]
        public void TestMult()
        {
            // Arrange
            var calc = new Calculator();

            // Act
            var div = calc.mult(2, 1);
            var div1 = calc.mult(0, 0);
            var div2 = calc.mult(1, -1);

            // Assert
            Assert.AreEqual(2, div);
            Assert.AreEqual(0, div1);
            Assert.AreEqual(-1, div2);
        }

        [TestMethod]
        public void TestSqr()
        {
            // Arrange
            var calc = new Calculator();

            // Act
            var div = calc.sqr(2);
            var div1 = calc.sqr(0);

            // Assert
            Assert.AreEqual(4, div);
            Assert.AreEqual(0, div1);

        }

        [TestMethod]
        public void TestSqrt()
        {
            // Arrange
            var calc = new Calculator();

            // Act
            var div = calc.sqrt(9);
            var div1 = calc.sqrt(0);

            // Assert
            Assert.AreEqual(3, div);
            Assert.AreEqual(0, div1);

        }


    }
}
