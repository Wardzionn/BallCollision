using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private Calculator.Calculator calc;
        [TestInitialize]
        public void Initialize()
        {
            calc = new Calculator.Calculator();
        }

        [TestMethod]
        public void addTest()
        {
            Assert.AreEqual(calc.add(3, 4), 7);
            Assert.AreEqual(calc.add(10.2, 20.3), 30.5);
        }

        [TestMethod]
        public void subtractTest()
        {
            Assert.AreEqual(calc.subtract(3, 4), -1);
            Assert.AreEqual(calc.subtract(-1, -1), 0);
        }

        [TestMethod]
        public void multiplyTest()
        {
            Assert.AreEqual(calc.multiply(3, 4), 12);
            Assert.AreEqual(calc.multiply(-1, -1), 1);
        }

        [TestMethod]
        public void divideTest()
        {
            Assert.AreEqual(calc.divide(4, 4), 1);
            Assert.AreEqual(calc.divide(-1, -1), 1);
        }
    }
}