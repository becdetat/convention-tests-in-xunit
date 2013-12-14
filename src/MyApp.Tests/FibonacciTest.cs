using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyApp.Shared;
using Xunit;
using Xunit.Extensions;

namespace MyApp.Tests
{
    public class FibonacciTest
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 1)]
        [InlineData(2, 1)]
        [InlineData(3, 2)]
        [InlineData(4, 3)]
        [InlineData(5, 5)]
        [InlineData(6, 8)]
        [InlineData(7, 13)]
        [InlineData(8, 21)]
        [InlineData(16, 987)]
        public void TestNumber(int sequence, int result)
        {
            Assert.Equal(result, FibonacciGenerator.For(sequence));
        }
    }
}
