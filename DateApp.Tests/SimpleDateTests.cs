using System;
using Xunit;

namespace DateApp.Tests
{
    public class SimpleDateTests
    {
        [Theory]
        [InlineData(0,1,2020)]
        [InlineData(32,1,2020)]
        [InlineData(1,0,2020)]
        [InlineData(1,13,2020)]
        [InlineData(1,1,0)]
        public void Constructor_InvalidArguments_Throws(int day, int month, int year)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new SimpleDate(day, month, year));
        }

        [Fact]
        public void ToString_ReturnsExpectedFormat()
        {
            var d = new SimpleDate(5, 6, 2022);
            Assert.Equal("5/6/2022", d.ToString());
        }
    }
}
