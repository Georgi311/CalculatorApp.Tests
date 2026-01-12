using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorApp;

namespace CalculatorApp.Tests
{
    [TestClass]
    public class CalculatorUnitTest
    {
        [TestMethod]
        public void Add_ShouldReturnCorrectSum()
        {
            var calc = new Calculator();
            int result = calc.Add(5, 3);
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void Subtract_ShouldReturnCorrectDifference()
        {
            var calc = new Calculator();
            int result = calc.Subtract(10, 4);
            Assert.AreEqual(6, result);
        }
    }
}
