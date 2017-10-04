using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01
{
    class Program
    {
        static void Main(string[] args)
        {
            var pokePower = long.Parse(Console.ReadLine()); //N
            var distance = long.Parse(Console.ReadLine()); //M
            var exhaustionRate = long.Parse(Console.ReadLine()); //Y

           var powerStart = pokePower / 2; // 2

            long count = 0;
            
            while(pokePower >= distance && pokePower >= 0)
            {
                if (pokePower == powerStart && pokePower > 0 && exhaustionRate > 0)
                {
                    pokePower /= exhaustionRate;
                }
                if (pokePower >= distance && pokePower > 0)
                {             
                    count++;
                    pokePower -= distance;
                } 
                else 
                {
                    break;
                }
            }
           
            Console.WriteLine($"{pokePower}\r\n{count}");
          
        }
    }
}
