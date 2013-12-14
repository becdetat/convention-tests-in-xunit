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
    public class FibonacciTestUsingPropertyData
    {
        public static IEnumerable<object[]> TestData
        {
            get
            {
                yield return new object[] { 0, 0 };
                yield return new object[] { 1, 1 };
                yield return new object[] { 2, 1 };
                yield return new object[] { 3, 2 };
                yield return new object[] { 4, 3 };
                yield return new object[] { 5, 5 };
                yield return new object[] { 6, 8 };
                yield return new object[] { 7, 13 };
                yield return new object[] { 8, 21 };
                yield return new object[] { 16, 987 };
            }
        }

        [Theory]
        [PropertyData("TestData")]
        public void TestNumber(int sequence, int result)
        {
            Assert.Equal(result, FibonacciGenerator.For(sequence));
        }

    }
}
