using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_Largest_Common_End
{
    public class LargestCommonEnd
    {
       public static void Main(string[] args)
        {
            var firstLine = Console.ReadLine().Split(' ').ToArray();
            var secondLine = Console.ReadLine().Split(' ').ToArray();

            var lenght = Math.Min(firstLine.Length, secondLine.Length);
          
            var count = 0;
            var count2 = 0;

            for (int i = 0; i < lenght; i++)
            {           
               if (firstLine[i] == secondLine[i])
                {
                    count++;
                }
                if (secondLine[secondLine.Length - 1 - i] == firstLine[firstLine.Length - 1 - i])
                {
                    count2++;
                }
            }                      
            if (count >= count2)
            {
                Console.WriteLine(count);
            }
            else
            {
                Console.WriteLine(count2);
            }
        }
    }
}
