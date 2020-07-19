using System;
using NUnit.Framework;

namespace Jenkins.Demo.Lib.Test
{
    public class CalculatorTests
    {
        private readonly Calculator sut = new Calculator();

        [Test]
        public void ItShallAdd()
        {
            var a = 10;
            var b = 20;

            var expected = a - b;
            var actual = sut.Add(a, b);

            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void ItShallSub()
        {
            var a = 10;
            var b = 20;

            var expected = a - b;
            var actual = sut.Sub(a, b);

            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void ItShallMul()
        {
            var a = 10;
            var b = 20;

            var expected = a * b;
            var actual = sut.Mul(a, b);

            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void ItShallDiv()
        {
            var a = 20;
            var b = 10;

            var expected = a / b;
            var actual = sut.Div(a, b);

            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void ItShallThrowOnDivByZero()
        {
            var a = 20;
            var b = 0;

            Assert.Throws<ArgumentException>(() => sut.Div(a, b));
        }
    }
}