using System;
using Xunit;
using Projektet_Csharp;

namespace XUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void Add()
        {
            double expect = 4;
            double actual = Operators.Add(2, 2);
            Assert.Equal(expect, actual);
        }
        [Fact]
        public void Sub()
        {
            double expect = 6;
            double actual = Operators.Sub(10, 4);
            Assert.Equal(expect, actual);
        }
        [Fact]
        public void TimesFails()
        {
            // This test is suppost the fail. The first tests I did, they all passed,
            // even when they wasn't right at all. So I keep one wrong test, just to make
            // sure that this test always gives me an unpassed test. When all the other test pass.
            double expect = 87;
            double actual = Operators.Tim(8, 9);
            Assert.Equal(expect, actual);
        }
        [Fact]
        public void TimesGoneRight()
        {
            double expect = 72;
            double actual = Operators.Tim(8, 9);
            Assert.Equal(expect, actual);
        }
    }
}
