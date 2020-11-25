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
            Parse.Parser("four", "two plus two");
        }
        [Fact]
        public void Sub()
        {
            Assert.Equal("six", "ten minus four");
        }
        [Fact]
        public void Times()
        {
            Assert.Equal("eight", "two times four");
        }
    }
}
