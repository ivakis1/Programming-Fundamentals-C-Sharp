using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace P08_Mines
{
    class Mines
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();

            var startIndex = 0;
            var endIndex = 0;

            while ((startIndex = text.IndexOf("<", startIndex)) != -1 
              && (endIndex = text.IndexOf(">", endIndex)) != -1)
            {
                string bombChars = text.Substring(startIndex + 1, 2);
                int bombStrenght = CalcBombStr(bombChars);

                int leftFromTheBomb = Math.Max(0, startIndex - bombStrenght);
                int rightFromTheBomb = Math.Min(text.Length - 1, endIndex + bombStrenght);

                StringBuilder sb = new StringBuilder(text);

                for (int i = leftFromTheBomb; i <= rightFromTheBomb; i++)
                {
                    sb[i] = '_';
                }
                text = sb.ToString();
            }

            Console.WriteLine(text);
        }

        private static int CalcBombStr(string bombChars)
        {
            return Math.Abs(bombChars[0] - bombChars[1]);
        }
    }
}
