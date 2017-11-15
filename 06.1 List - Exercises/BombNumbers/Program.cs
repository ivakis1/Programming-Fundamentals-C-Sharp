using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(x => int.Parse(x)).ToList();
            var bombNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            var bombPosition = 0;

            var result = new List<int>();

            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] == bombNumbers[0])
                {
                    bombPosition = i;

                 
                }



            }


            Console.WriteLine(result.Sum());

        }
    }
}
