namespace P07_BombNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class BombNumbers
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().Select(x => int.Parse(x)).ToList();
            var bombNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] == bombNumbers[0])
                {
                    input[i] = 0;
                    for (int j = 1; j <= bombNumbers[1]; j++)
                    {
                        if (i + j >= input.Count)
                        {
                            break;
                        }
                        else
                        {
                            input[i + j] = 0; ;
                        }
                    }
                    for (int k = 1; k <= bombNumbers[1]; k++)
                    {
                        if (i - k < 0)
                        {
                            break;
                        }
                        else
                        {
                            input[i - k] = 0;
                        }
                    }

                }

            }
            Console.WriteLine(input.Sum());
        }
    }
}

