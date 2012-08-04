using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EulerCs
{
    public class Euler19
    {
        public struct Date
        {
            public int Day;
            public int Month;
            public int Year;
        }

        public int FebDays (int y)
        {
            if (y % 400 == 0)
                return 29;

            if (y % 100 == 0)
                return 28;

            return y % 4 == 0 ? 29 : 28;
        }

        public int DaysInMonth (int m, int y)
        {
            if (m == 2)
                return FebDays(y);

            return m == 4 || m == 6 || m == 9 || m == 11 ? 30 : 31;
        }

        public Date AddDay (Date date)
        {
            if (date.Day < 1  || date.Day > DaysInMonth(date.Month,date.Year))
                throw new Exception("Day can not be less than 1 or more than the number of days in the month.");

            if (date.Day == DaysInMonth(date.Month, date.Year))
            {
                if (date.Month < 1 || date.Month > 12)
                    throw new Exception("Month can not be less than 1 or more than 12.");

                date.Day = 1;

                if (date.Month == 12)
                {
                    date.Month = 12;
                    date.Year++;
                    return date;
                }

                date.Month++;

                return date;
            }

            date.Day++;
            return date;
        }

        public Date AddDays(int days, Date date)
        {
            return new Date();
        }
    }
}
