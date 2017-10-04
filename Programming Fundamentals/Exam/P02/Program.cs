using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse).ToList();

            long sum = 0;
            long number = long.MinValue;

            while (true)
            {
                if (input.Count <= 0)
                {
                    break;
                }
                var index = int.Parse(Console.ReadLine());

                if (index >= 0 && index < input.Count) //
                {
                    number = input[index];
                    input.RemoveAt(index);
                }
                else if (index < 0)
                {
                    number = input.First();
                    var lastNumber = input.Last();
                    input[0] = lastNumber;
                }
                else if (index > input.Count)
                {
                    number = input.Last();
                    var fistNumber = input.First();
                    input[input.Count - 1] = fistNumber;
                }

                sum += number;

                for (int i = 0; i < input.Count; i++)
                {
                    if (input[i] <= number)
                    {
                        input[i] += number;
                    }
                    else
                    {
                        input[i] -= number;
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}

