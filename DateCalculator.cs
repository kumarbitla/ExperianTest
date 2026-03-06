using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateApp
{
    public class DateCalculator
    {
        private readonly IDaysInMonthStrategy _daysInMonthStrategy;
        public DateCalculator(IDaysInMonthStrategy daysInMonthStrategy)
        {
            _daysInMonthStrategy = daysInMonthStrategy;
        }
        public SimpleDate AddDays(SimpleDate date, int daysToAdd)
        {
            int day = date.Day;
            int month = date.Month;
            int year = date.Year;
            while (daysToAdd > 0)
            {
                int daysInCurrentMonth = _daysInMonthStrategy.GetDays(month, year);
                if (day + daysToAdd <= daysInCurrentMonth)
                {
                    day += daysToAdd;
                    daysToAdd = 0;
                }
                else
                {
                    daysToAdd -= (daysInCurrentMonth - day + 1);
                    day = 1;
                    month++;
                    if (month > 12)
                    {
                        month = 1;
                        year++;
                    }
                }
            }
            return new SimpleDate(day, month, year);
        }
    }
}
