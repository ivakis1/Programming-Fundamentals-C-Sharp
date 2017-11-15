using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var secTokens = int.Parse(Console.ReadLine());

            var totalLost = 0M;

            for (int i = 0; i < n ; i++)
            {
                var inputArgs = Console.ReadLine().Split();
                var siteName = inputArgs[0];
                var siteVisits = int.Parse(inputArgs[1]);
                var siteCompersialPricePerVisit = decimal.Parse(inputArgs[2]);

                totalLost += siteVisits * siteCompersialPricePerVisit;

                Console.WriteLine(siteName);
            }
            Console.WriteLine($"Total Loss: {totalLost}");
            Console.WriteLine(Math.Pow(secTokens, n));
        }
    }
}
