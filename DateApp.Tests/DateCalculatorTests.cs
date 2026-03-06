using Xunit;
using DateApp;

namespace DateApp.Tests
{
    public class DateCalculatorTests
    {
        [Fact]
        public void AddDays_CrossMonthAndYear_ReturnsCorrect()
        {
            var strategy = new GregorianDaysStrategy();
            var calc = new DateCalculator(strategy);
            var start = new SimpleDate(28, 2, 2021);
            var result = calc.AddDays(start, 3);
            Assert.Equal(3, result.Day);
            Assert.Equal(3, result.Month);
            Assert.Equal(2021, result.Year);
        }

        [Fact]
        public void AddDays_AtYearEnd_RollsToNextYear()
        {
            var strategy = new GregorianDaysStrategy();
            var calc = new DateCalculator(strategy);
            var start = new SimpleDate(31, 12, 2020);
            var result = calc.AddDays(start, 1);
            Assert.Equal(1, result.Day);
            Assert.Equal(1, result.Month);
            Assert.Equal(2021, result.Year);
        }
    }
}
