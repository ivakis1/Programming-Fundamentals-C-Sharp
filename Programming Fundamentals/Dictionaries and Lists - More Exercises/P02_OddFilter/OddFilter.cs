using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_OddFilter
{
   public class OddFilter
    {
       public static void Main()
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();

            input.RemoveAll(x => x % 2 != 0);

            //OR
            //intput.Where(x => x % 2 == 0);

            var average = input.Average();

            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] > average)
                {
                    input[i] += 1;
                }
                else
                {
                    input[i] -= 1;
                }
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
