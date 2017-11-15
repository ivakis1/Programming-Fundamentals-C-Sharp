using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06
{
    class OnlyLetters
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var count = 0;
            var nums = "";

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    count++;
                    nums += input[i];
                }
                if (char.IsLetter(input[i]) && count > 0)
                {
                    input = input.Replace(nums, input[i].ToString());
                    nums = "";
                    count = 0;
                }
                
            }
            Console.WriteLine(input);
        }
    }
}

