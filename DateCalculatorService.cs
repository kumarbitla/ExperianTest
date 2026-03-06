using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateApp
{
    public class DateCalculatorService
    {
        public string AddDays(string inputDate, int daysToAdd)
        {
            SimpleDate dateObj = DateParser.Parse(inputDate);
            DateCalculator calculator = new DateCalculator();
            SimpleDate newDate = calculator.AddDays(dateObj, daysToAdd);
            return newDate.ToString();
        }
    }
}