using System;
using Xunit;
using DateApp;

namespace DateApp.Tests
{
    public class DateCalculatorServiceTests
    {
        [Fact]
        public void AddDays_ValidInput_ReturnsCorrectString()
        {
            var service = new DateCalculatorService();
            var result = service.AddDays("31/12/2020", 1);
            Assert.Equal("1/1/2021", result);
        }

        [Fact]
        public void AddDays_InvalidInput_ThrowsFormatException()
        {
            var service = new DateCalculatorService();
            Assert.Throws<FormatException>(() => service.AddDays("invalid", 5));
        }

        [Fact]
        public void AddDays_LeapYear_ReturnsFeb29()
        {
            var service = new DateCalculatorService();
            var result = service.AddDays("28/02/2020", 1);
            Assert.Equal("29/2/2020", result);
        }

        [Fact]
        public void AddDays_ZeroDays_ReturnsSameDate()
        {
            var service = new DateCalculatorService();
            var result = service.AddDays("05/06/2022", 0);
            Assert.Equal("5/6/2022", result);
        }
    }
}
