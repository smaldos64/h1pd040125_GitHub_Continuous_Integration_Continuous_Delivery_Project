using MathLibrary;
using Xunit;

namespace GitHub_Projekt1
{
    public class MathOperationsTests
    {
        [Fact]
        public void Add_ShouldReturnCorrectSum()
        {
            // Arrange
            int a = 5;
            int b = 3;
            int expected = 8;

            // Act
            int result = MathOperations.Add(a, b);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Add_ShouldReturnIncorrectSum()
        {
            // Arrange
            int a = 2;
            int b = 3;
            int expected = 12;

            // Act
            int result = MathOperations.Add(a, b);

            // Assert
            Assert.NotEqual(expected, result);
        }

        [Fact]
        public void Subtract_ShouldReturnCorrectDifference()
        {
            // Arrange
            int a = 10;
            int b = 5;
            int expected = 5;

            // Act
            int result = MathOperations.Subtract(a, b);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Multiply_ShouldReturnCorrectProduct()
        {
            // Arrange
            int a = 5;
            int b = 3;
            int expected = 15;

            // Act
            int result = MathOperations.Multiply(a, b);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]  // Læg mærke til at vi bruger Theory her, da vi også 
                  // bruger InLineData !!!
        [InlineData(5, 3, 15)]  // TestCase 1
        [InlineData(5, 4, 20)]  // TestCase 2
        [InlineData(21, 19, 399)]  // TestCase 3
        [InlineData(101, 99, 9999)]  // TestCase 4

        public void Multiply_ShouldReturnCorrectProductMultipleTestCases(int a, int b, int expected)
        {
            // Arrange
            //int a = 5;
            //int b = 3;
            //int expected = 15;

            // Act
            int result = MathOperations.Multiply(a, b);

            // Assert
            Assert.Equal(expected, result);
        }


        [Fact]
        public void Divide_ShouldReturnCorrectQuotient()
        {
            // Arrange
            int a = 10;
            int b = 2;
            double expected = 5.0;

            // Act
            double result = MathOperations.Divide(a, b);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Divide_ShouldThrowException_WhenDivisorIsZero()
        {
            // Arrange
            int a = 10;
            int b = 0;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => MathOperations.Divide(a, b));
        }
    }
}
