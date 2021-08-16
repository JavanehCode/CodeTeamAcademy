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

            int a = 100;
            int b = 200;

            int actual = calculator.Add(a, b);

            var expected = 300;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddTwoDoubles()
        {
            MyCalculator calculator = new MyCalculator();

            double a = 10.3D;
            double b = 20.2D;

            double actual = calculator.Add(a, b);

            var expected = 30.5D;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddTwoLong()
        {
            MyCalculator calculator = new MyCalculator();

            long a = 10000000000;
            long b = 20000000000;

            long actual = calculator.Add(a, b);

            var expected = 30000000000;

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void MultiplyTwoIntegers()
        {
            MyCalculator calculator = new MyCalculator();

            int a = 200;
            int b = 300;

            int actual = calculator.Multiply(a, b);

            var expected = 60000;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MultiplyTwoDoubles()
        {
            MyCalculator calculator = new MyCalculator();

            double a = 200.2;
            double b = 300.456;

            double actual = calculator.Multiply(a, b);

            var expected = 60151.2912D;

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void MultiplyTwoLongs()
        {
            MyCalculator calculator = new MyCalculator();

            long a = 222;
            long b = 12000000000;

            long actual = calculator.Multiply(a, b);

            var expected = 2664000000000;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DivideIntegers()
        {
            MyCalculator calculator = new MyCalculator();

            int a = 23;
            int b = 4;

            (int quotient, int remainder) = calculator.Divide(a, b);

            var expectedQuotient = 5;
            var expectedRemainder = 3;

            Assert.AreEqual(expectedQuotient, quotient);
            Assert.AreEqual(expectedRemainder, remainder);
        }

        [TestMethod]
        public void DivideLongs()
        {
            MyCalculator calculator = new MyCalculator();

            long a = 10000000002;
            long b = 4;

            (long quotient, long remainder) = calculator.Divide(a, b);

            var expectedQuotient = 2500000000;
            var expectedRemainder = 2;

            Assert.AreEqual(expectedQuotient, quotient);
            Assert.AreEqual(expectedRemainder, remainder);
        }

        [TestMethod]
        public void SubtractIntegers()
        {
            MyCalculator calculator = new MyCalculator();

            int a = 100;
            int b = 200;

            int actual = calculator.Subtract(a, b);

            var expected = -100;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SubtractDoubles()
        {
            MyCalculator calculator = new MyCalculator();

            double a = 300D;
            double b = 200D;

            double actual = calculator.Subtract(a, b);

            var expected = 100D;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SubtractLongs()
        {
            MyCalculator calculator = new MyCalculator();

            long a = 1000;
            long b = 1020;

            long actual = calculator.Subtract(a, b);

            var expected = -20M;

            Assert.AreEqual(expected, actual);
        }
    }
}
