using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {

            var initialDate = Console.ReadLine();


            DateTime date = DateTime.ParseExact(initialDate, "d-M-yyyy",
                CultureInfo.InvariantCulture);
           

            Console.WriteLine(date.DayOfWeek);
        }
    }
}
