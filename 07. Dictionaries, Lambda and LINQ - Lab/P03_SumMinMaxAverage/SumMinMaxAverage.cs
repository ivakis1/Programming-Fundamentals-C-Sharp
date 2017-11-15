using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_SumMinMaxAverage
{
    class SumMinMaxAverage
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var listNumbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                listNumbers[i] = int.Parse(Console.ReadLine());

             //   listNumbers[i] = curentNum;
            }

            Console.WriteLine($"Sum = {listNumbers.Sum()}");
            Console.WriteLine($"Min = {listNumbers.Min()}");
            Console.WriteLine($"Max = {listNumbers.Max()}");
            Console.WriteLine($"Average = {listNumbers.Average()}");

        }
    }
}
