namespace P01_CountWorkingDays
{
    using System;
    using System.Globalization;

   public class CountWorkingDays
    {
        static void Main(string[] args)
        {
            var startDate = Console.ReadLine();
            var endDate = Console.ReadLine();

            DateTime firstDate = DateTime.ParseExact(startDate, "d-M-yyyy",
                CultureInfo.InvariantCulture);

            DateTime secondDate = DateTime.ParseExact(endDate, "d-M-yyyy",
                            CultureInfo.InvariantCulture);

            var workDaysCounter = 0;

            for (DateTime date = firstDate; date <= secondDate; date = date.AddDays(1))
            {
                if (!((date.Month == 01 && date.Day == 01) || (date.Month == 03 && date.Day == 03) || (date.Month == 05 && date.Day == 01) ||
                    (date.Month == 05 && date.Day == 06) || (date.Month == 05 && date.Day == 24) || (date.Month == 09 && date.Day == 06) ||
                    (date.Month == 09 && date.Day == 22) || (date.Month == 10 && date.Day == 01) || (date.Month == 12 && date.Day == 24) ||
                     (date.Month == 12 && date.Day == 25) || (date.Month == 12 && date.Day == 26)))
                {
                    if (!((date.DayOfWeek.Equals(DayOfWeek.Saturday) || (date.DayOfWeek.Equals(DayOfWeek.Sunday)))))
                    {
                        workDaysCounter++;
                    }

                }

            }
            Console.WriteLine(workDaysCounter);

        }


    }
}
