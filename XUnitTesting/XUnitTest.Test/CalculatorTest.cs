using System;
using Xunit;

namespace XUnitTest.Test
{
    public class CalculatorTest
    {
        private readonly Calculator calculator;

        public CalculatorTest()
        {
            calculator = new Calculator();
        }

        #region ³Ë·¨
        [Fact]
        public void OneMutiOneIsOne()
        {
            var result = calculator.Multi(1, 1);
            Assert.Equal(1, result);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        public void ReturnValue(int value)
        {
            var result = calculator.Multi(1, value);

            Assert.Equal(result, value);
        }
        #endregion

        #region Å¼Êý
        [Fact]
        public void NumIsEven()
        {
            int value = 3;
            var result = calculator.IsEven(value);
            Assert.True(result, $"{value} is not even number");
        }

        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        public void ReturnTrueIfEven(int value)
        {
            var result = calculator.IsEven(value);
            Assert.True(result, $"{value} is not even number");
        }
        #endregion
    }
}
