using Xunit;
using Calculator;

namespace UnitTestProject1
{
    // A - Arrange
    // A - Act
    // A - Assert


    public class CalculatorTests
    {
        [Fact]
        public void AddTwoIntegers()
        {
            var calculator = new Calculator.Calculator();
            var result = calculator.Add(5, 3);
            Assert.Equal(8, result);
        }


        [Fact]
        public void ThrowExceptionWhenDividingByZero()
        {
        }
    }
}
