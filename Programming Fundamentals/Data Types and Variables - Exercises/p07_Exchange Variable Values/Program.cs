using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p07_Exchange_Variable_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;

            Console.WriteLine("Before:\na = {0}\nb = {1} ", a, b);

            int oldA = a;
            a = b;
            b = oldA;

            Console.WriteLine("After:\na = {0}\nb = {1} ", a, b);

        
        }
    }
}
