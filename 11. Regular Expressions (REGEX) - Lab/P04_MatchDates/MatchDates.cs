using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace P04_MatchDates
{
    class MatchDates
    {
        static void Main(string[] args)
        {
            var regex = @"\b(?<day>\d{2})([-|\/|\.])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";

            var dates = Console.ReadLine();

            var sortedDates = Regex.Matches(dates, regex);

            foreach (Match date in sortedDates)
            {
                var day = date.Groups["day"].Value;
                var month = date.Groups["month"].Value;
                var year = date.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
