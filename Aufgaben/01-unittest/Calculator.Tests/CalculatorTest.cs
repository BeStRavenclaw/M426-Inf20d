using System;
using Xunit;

namespace Calculator.Tests
{
    public class CalculatorTest
    {
        [Fact]
        public void TestAddThreeToTwoIsFive()
        {
            // Arrange
            int a = 2;
            int b = 3;
            int expected = 5;
            Calculator calculator = new Calculator();

            // Act
            int actual = calculator.Add(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestSubstractFourFromNineIsFive()
        {
            // Given
            int a = 9;
            int b = 4;
            int expected = 5;
            Calculator calculator = new Calculator();

            // When
            int actual = calculator.Subtract(a, b);

            // Then
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMultiplyTwoWhithThreeIsSix()
        {
            int a = 2;
            int b = 3;
            int expected = 6;
            Calculator calculator = new Calculator();

            int actual = calculator.Multiply(a, b);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestDivideSixByTwoIsThree()
        {
            int a = 6;
            int b = 2;
            int expected = 3;
            Calculator calculator = new Calculator();

            int actual = calculator.Divide(a, b);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestDivideByZeroException()
        {
            int a = 6;
            int b = 0;
            Calculator calculator = new Calculator();

            Assert.Throws<ArgumentException>(() => calculator.Divide(a, b));
        }
    }
}
