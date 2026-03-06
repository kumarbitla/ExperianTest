using System;
using Xunit;

namespace DateApp.Tests
{
    public class DateParserTests
    {
        [Fact]
        public void Parse_ValidInput_ReturnsExpected()
        {
            var input = "29/01/2016";
            var result = DateParser.Parse(input);
            Assert.Equal(29, result.Day);
            Assert.Equal(1, result.Month);
            Assert.Equal(2016, result.Year);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("invalid")]
        [InlineData("ab/cd/efgh")]
        [InlineData("1/1/2016")]
        public void Parse_InvalidInput_ThrowsFormatException(string input)
        {
            Assert.Throws<FormatException>(() => DateParser.Parse(input));
        }

        [Fact]
        public void Parse_ValidWithLeadingZeros_ReturnsExpected()
        {
            var input = "05/06/2022";
            var result = DateParser.Parse(input);
            Assert.Equal(5, result.Day);
            Assert.Equal(6, result.Month);
            Assert.Equal(2022, result.Year);
        }
    }
}
