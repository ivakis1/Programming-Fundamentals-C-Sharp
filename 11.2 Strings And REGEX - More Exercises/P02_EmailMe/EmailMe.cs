using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace P02_EmailMe
{
    class EmailMe
    {
        static void Main(string[] args)
        {
            var pattern = @"(?<name>.+)@(?<host>.+)";

            var meil = Console.ReadLine();

            var matches = Regex.Match(meil, pattern);

            var leftSideSum = 0;
            var rightSideSum = 0;

            var leftSide = matches.Groups["name"].Value;
            var rightSide = matches.Groups["host"].Value;

            var left = leftSide.ToCharArray();
            var right = rightSide.ToCharArray();

            for (int i = 0; i < leftSide.Length; i++)
            {
                leftSideSum += left[i];
            }
            for (int i = 0; i < rightSide.Length; i++)
            {
                rightSideSum += right[i];
            }
            if (leftSideSum == rightSideSum || leftSideSum - rightSideSum > 0)
            {
                Console.WriteLine("Call her!");
            }
            else
            {
                Console.WriteLine("She is not the one.");
            }
         
        }
    }
}
