using CalculatorLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdd()
        {
            // Arrange
            CalculatorService calculator = new CalculatorService();

            // Act
            decimal result1 = calculator.Add(5, 3);
            decimal result2 = calculator.Add(0, 0);
            decimal result3 = calculator.Add(-5, 3);
            decimal result4 = calculator.Add(10, -2);
            decimal result5 = calculator.Add(0.5m, 0.5m);

            // Assert
            Assert.AreEqual(8, result1);
            Assert.AreEqual(0, result2);
            Assert.AreEqual(-2, result3);
            Assert.AreEqual(8, result4);
            Assert.AreEqual(1, result5);
        }

        [TestMethod]
        public void TestSub()
        {
            // Arrange
            CalculatorService calculator = new CalculatorService();

            // Act
            decimal result1 = calculator.sub(5, 3);
            decimal result2 = calculator.sub(0, 0);
            decimal result3 = calculator.sub(-5, 3);
            decimal result4 = calculator.sub(10, -2);
            decimal result5 = calculator.sub(0.5m, 0.5m);

            // Assert
            Assert.AreEqual(2, result1);
            Assert.AreEqual(0, result2);
            Assert.AreEqual(-8, result3);
            Assert.AreEqual(12, result4);
            Assert.AreEqual(0, result5);
        }

        [TestMethod]
        public void TestMul()
        {
            // Arrange
            CalculatorService calculator = new CalculatorService();

            // Act
            decimal result1 = calculator.Mul(5, 3);
            decimal result2 = calculator.Mul(0, 0);
            decimal result3 = calculator.Mul(-5, 3);
            decimal result4 = calculator.Mul(10, -2);
            decimal result5 = calculator.Mul(0.5m, 0.5m);

            // Assert
            Assert.AreEqual(15, result1);
            Assert.AreEqual(0, result2);
            Assert.AreEqual(-15, result3);
            Assert.AreEqual(-20, result4);
            Assert.AreEqual(0.25m, result5);
        }

        [TestMethod]
        public void TestDiv()
        {
            // Arrange
            CalculatorService calculator = new CalculatorService();

            // Act
            decimal result1 = calculator.Div(6, 2);
            decimal result2 = calculator.Div(0, 5);
            decimal result3 = calculator.Div(-10, -2);
            decimal result4 = calculator.Div(8, 4);
            decimal result5 = calculator.Div(1.5m, 0.5m);

            // Assert
            Assert.AreEqual(3, result1);
            Assert.AreEqual(0, result2);
            Assert.AreEqual(5, result3);
            Assert.AreEqual(2, result4);
            Assert.AreEqual(3, result5);
        }
    }
}