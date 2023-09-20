using System;
using System.Collections.Generic;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData(5, 1, 6, 12)]
        [InlineData(46495, 525, 436, 47456)]
        [InlineData(111, 222, 333, 666)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {

            var instance = new Calculator();

            var actual = instance.Add(num1, num2, num3);

            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(0, 0, new int[] {0})]
        [InlineData(234, 333, new int[] {-99})]
        [InlineData(111, 222, new int[] {-111})]
        public void SubtractTest(int minuend, int subtrhend, System.Collections.Generic.IEnumerable<int> expected)
        {
            var actual = Calculator.Subtract(minuend, subtrhend);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3423, 0, 0)]
        [InlineData(561, 23, 12903)]
        public void MultiplyTest(int num1, int num2, int expected)
        {

            var actual = Calculator.Multiply(num1, num2);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 2, 5)]
        [InlineData(20, 4, 5)]
        [InlineData(8, 0, 0)]
        public void DivideTest(int num1, int num2, int expected)
        {
            var actual = Calculator.Divide(num1, num2);

            Assert.Equal(expected, actual);
        }

    }
}
