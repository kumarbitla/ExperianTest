using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateApp
{
    public class GregorianDaysStrategy : IDaysInMonthStrategy
    {
        public int GetDays(int month, int year)
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