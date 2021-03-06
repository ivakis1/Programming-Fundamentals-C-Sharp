﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p09_Debug_the_Code_Holidays_between_two_dates
{
    using System;
    using System.Globalization;
    class HolidaysBetweenTwoDates
    {
        static void Main(string[] args)
        {

            var startDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);

            var endDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);

            var holidaysCount = 0;

            for (var date = startDate; date <= endDate; date = date.AddDays(1))
            {
                if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                { 
                    holidaysCount++;
                }
            }

            Console.WriteLine(holidaysCount); 

        }

    }
}
    

