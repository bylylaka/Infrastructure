using Infrastructure.Calculators;
using Infrastructure.Controllers;
using System;
using Xunit;

namespace Infrastructure.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void AddTest()
        {
            var res = Calculator.Add(5, 7);
            Assert.Equal(11, res);
        }

        [Fact]
        public void RemoveTest()
        {
            var res = Calculator.Remove(7, 5);
            Assert.Equal(2, res);
        }
    }
}
