using CalculatorLibrary;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Xunit;

namespace CalculatorTest
{

    public class UnitTest1
    {

        public class CalculatorTests
        {
            [Fact]
            public void AddTwoIntegers()
            {
                var calculator = new Calculator();

                var result = calculator.Add(1, 2);
                Assert.Equal(3, result);
            }





            [Theory]
            [InlineData(1, 2, 3)]
            [InlineData(100, 0, 100)]
            [InlineData(0, 200, 200)]

            public void AddTwoIntegersTheory(int a, int b, int result)
            {
                var calculator = new Calculator();

                var addResult = calculator.Add(a, b);
                Assert.Equal(result, addResult);
            }






            [Theory]
            [MemberData(nameof(AddData))]

            public void AddTwoIntegersMemberData(int a, int b, int result)
            {
                var calculator = new Calculator();

                var addResult = calculator.Add(a, b);
                Assert.Equal(result, addResult);
            }

            public static IEnumerable<object[]> AddData()
            {
                return null;
            }
        }
    }
}








// A - Arrange
// A - Act
// A - Assert
/*
[TestClass]
public class CalculatorTests
{
    [TestMethod]
    public void AddTwoIntegers()
    {
        var calculator = new Calculator();

        var result = calculator.Add(1, 2);
        Assert.AreEqual(3, result);
    }


    [TestMethod]
    public void ThrowExceptionWhenDividingByZero()
    {
        var calculator = new Calculator();

        //var result = calculator.Divide(4, 0);

        Assert.ThrowsException<DivideByZeroException>(() => calculator.Divide(4, 0));
    }
}

}

}
   */
