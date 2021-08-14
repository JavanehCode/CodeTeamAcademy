using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Tests
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void AddTwoIntegers()
        {
            MyCalculator calculator = new MyCalculator();

            int actual = calculator.Add(100, 200);

            var expected = 300;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddTwoDoubles()
        {
            MyCalculator calculator = new MyCalculator();

            double actual = calculator.Add(10.3D, 20.2D);

            var expected = 30.5D;

            Assert.AreEqual(expected, actual);  
        }

        [TestMethod]
        public void AddTwoLong()
        {
            MyCalculator calculator = new MyCalculator();

            long actual = calculator.Add(10000000000, 20000000000);

            var expected = 30000000000;

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void MultiplyTwoIntegers()
        {
            MyCalculator calculator = new MyCalculator();

            int actual = calculator.Multiply(200, 300);

            var expected = 60000;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MultiplyTwoDoubles()
        {
            MyCalculator calculator = new MyCalculator();

            double actual = calculator.Multiply(200.2, 300.456);

            var expected = 60151.2912D;

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void MultiplyTwoLongs()
        {
            MyCalculator calculator = new MyCalculator();

            long actual = calculator.Multiply(222M, 12000000000);

            var expected = 2664000000000;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DivideIntegers()
        {
            MyCalculator calculator = new MyCalculator();

            (int quotient, int remainder) = calculator.Divide(23, 4);

            var expectedQuotient = 5;
            var expectedRemainder = 3;

            Assert.AreEqual(expectedQuotient, quotient);
            Assert.AreEqual(expectedRemainder, remainder);
        }

        [TestMethod]
        public void DivideIntegers()
        {
            MyCalculator calculator = new MyCalculator();

            (long quotient, long remainder) = calculator.Divide(10000000002, 4);

            var expectedQuotient = 2500000000;
            var expectedRemainder = 2;

            Assert.AreEqual(expectedQuotient, quotient);
            Assert.AreEqual(expectedRemainder, remainder);
        }

        [TestMethod]
        public void SubtractIntegers()
        {
            MyCalculator calculator = new MyCalculator();

            int actual = calculator.Subtract(100, 200);

            var expected = -100;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SubtractDoubles()
        {
            MyCalculator calculator = new MyCalculator();

            double actual = calculator.Add(300D, 200D);

            var expected = 100D;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SubtractLongs()
        {
            MyCalculator calculator = new MyCalculator();

            long actual = calculator.Add(1000M, 1020M);

            var expected = -20M;

            Assert.AreEqual(expected, actual);
        }
    }
}
