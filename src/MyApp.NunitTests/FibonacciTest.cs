using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyApp.Shared;
using NUnit.Framework;

namespace MyApp.NunitTests
{
    public class FibonacciTest
    {
        [Test]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(3, 2)]
        [TestCase(4, 3)]
        [TestCase(5, 5)]
        [TestCase(6, 8)]
        [TestCase(7, 13)]
        [TestCase(8, 21)]
        [TestCase(16, 987)]
        public void TestNumber(int sequence, int result)
        {
            Assert.AreEqual(result, FibonacciGenerator.For(sequence));
        }
    }
}
