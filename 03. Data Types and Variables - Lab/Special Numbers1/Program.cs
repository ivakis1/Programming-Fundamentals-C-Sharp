using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Special_Numbers1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int sumDigits = 0;
                int digits = i;
                while (digits > 0)
                {
                    sumDigits += digits % 10;
                    digits = digits / 10;
               
                }

                bool special = (sumDigits == 5 || sumDigits == 7 || sumDigits == 11);
                Console.WriteLine("{0} -> {1}", i, special);
            }
        }
    }
}
