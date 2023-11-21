namespace ComarchCwiczenia.Tests
{
    public class CalculatorTests
    {
        Calculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [TestCase(2, 3)]
        [TestCase(0, 0)]
        public void AddShouldReturnCorrectResult(int x, int y)
        {
            //Arrange
            int expected = x + y;

            //Act
            int actual = calculator.Add(x, y);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(2, 3)]
        public void SubstractionShouldReturnCorrectResult(int x, int y)
        {
            //Arrange
            int expected = x - y;

            //Act
            int actual = calculator.Substraction(x, y);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(2, 3)]
        public void MultiplyShouldReturnCorrectResult(int x, int y)
        {
            //Arrange
            int expected = x * y;

            //Act
            int actual = calculator.Multiply(x, y);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(2, 3)]
        public void DivideShouldReturnCorrectResult(int x, int y)
        {
            //Arrange
            float expected = x / (float)y;

            //Act
            float actual = calculator.Divide(x, y);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(7, 6)]
        public void ModuloShouldReturnCorrectResult(int x, int y)
        {
            //Arrange
            int expected = x % y;

            //Act
            int actual = calculator.Modulo(x, y);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void ModuloShouldThrowExceptionWhenYEqual0()
        {
            //Arrange
            int x = 1; int y = 0;
            //Assert
            Assert.Throws<DivideByZeroException>(() => calculator.Modulo(x, y));
        }
        [Test]
        public void DivideShouldThrowExceptionWhenYEqual0()
        {
            //Arrange
            int x = 1; int y = 0;
            //Assert
            Assert.Throws<ArgumentException>(() => calculator.Divide(x, y));
        }
    }
}