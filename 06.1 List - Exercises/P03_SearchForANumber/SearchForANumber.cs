using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_SearchForANumber
{
    class SearchForANumber
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var corrections = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var result = input.Take(corrections[0]).ToList();

            result.RemoveRange(0, Math.Abs(corrections[1]));

            Console.WriteLine(result.Contains(corrections[2]) ? "YES!" : "NO!");          
        }
    }
}
