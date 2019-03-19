using System;
using NUnit.Framework;

namespace task_DEV_3.Tests
{
    [TestFixture]
    public class TestClass
    {
        [TestCase(16, 27, "1B")]
        [TestCase(2, 8, "1000")]
        [TestCase(20, -20, "-10")]
        [TestCase(10, 0, "0")]
        [Test]
        public void ValidInputDataTest(int radix, int number, string expected)
        {
            NumberConverter converter = new NumberConverter();
            Assert.AreEqual(expected, converter.Convert(number, radix));
        }

        [TestCase(16, 1)]
        [TestCase(2, 21)]
        [TestCase(20, -1)]
        [TestCase(10, 0)]
        [Test]
        public void NegativeInputDataTest(int number, int radix)
        {
            NumberConverter converter = new NumberConverter();
            Assert.Throws<ArgumentException>(() => converter.Convert(number, radix));
        }
    }
}
