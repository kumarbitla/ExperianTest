using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateApp
{
    public class DateCalculator
    {
        /// <summary>
        /// Adds the daysToAdd to the given date and returns the resulting date. It correctly handles month and year transitions, including leap years.
        /// </summary>
        /// <param name="date"></param>
        /// <param name="daysToAdd"></param>
        /// <returns></returns>
        public SimpleDate AddDays(SimpleDate date, int daysToAdd)
        {
            int day = date.Day;
            int month = date.Month;
            int year = date.Year;
            while (daysToAdd > 0)
            {
                int daysInCurrentMonth = GetDays(month, year);
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

        private int GetDays(int month, int year)
        {
            if (month == 2)
            {
                if (IsLeapYear(year))
                    return 29;
                else
                    return 28;
            }
            else if (month == 4 || month == 6 || month == 9 || month == 11)
                return 30;
            else
                return 31;
        }
        private bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0 || year % 400 == 0);
        }
    }
}
