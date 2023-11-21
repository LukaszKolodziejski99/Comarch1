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

        [Test]
        [TestCase(2, 3)]
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
    }
}