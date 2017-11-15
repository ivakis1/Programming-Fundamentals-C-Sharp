using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_ReverseString
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var reverseText = text.Reverse().ToArray();

            Console.WriteLine(reverseText);
        }
    }
}
