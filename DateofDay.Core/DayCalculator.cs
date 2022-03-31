using System;
using System.Collections.Generic;

namespace DateofDay.Core
{
    public class DayCalculator // zmieniłem na public 
    {
        /*
        public DateTimeOffset Date { get; set; }
        public DayCalculator(DateTimeOffset date)
        {
            Date = date;
        }
        */

        public DaysOfTheWeek CalculateDay(DateTimeOffset date)
        {
            var day = date.Day;   // przejmuejmy datę w funkcji
            var month = date.Month;
            var year = date.Year;


            var list1 = new List<int> { 0, 3, 2, 5, 0, 3, 5, 1, 4, 6, 2, 4 };
            int number = list1[0];
            if (month < 3)
                year -= 1;
            else
                year -= 0;

            var calculatedValue = (year + year / 4 - year / 100 + year / 400 + list1[month - 1] + day) % 7;

            return(DaysOfTheWeek)calculatedValue; /// rzutowanie na enuma
        }

    }
}
