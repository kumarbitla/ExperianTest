using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateApp
{
    public interface IDaysInMonthStrategy
    {
        int GetDays(int month, int year);
    }
}
