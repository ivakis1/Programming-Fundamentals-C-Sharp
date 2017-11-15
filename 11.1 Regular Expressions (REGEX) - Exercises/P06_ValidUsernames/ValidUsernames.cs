using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace P06_ValidUsernames
{
    class ValidUsernames
    {
        static void Main(string[] args)
        {
            var userNames = Console.ReadLine().Split(new char[] { ' ', '\\', '/', '(', ')' },
                StringSplitOptions.RemoveEmptyEntries).ToArray();

            var pattern = (@"\b([A-Za-z]+[0-9_A-Za-z]){3,25}\b");

            var names = new List<string>();

            foreach (var item in userNames)
            {
                var nameMatch = Regex.Match(item, pattern);

                if (nameMatch.Success)
                {
                    names.Add(nameMatch.Value);
                }
            }

            var firstUser = names[0]; // ""
            var secondUser = names[1]; // ""
            var sum = names[0].Length + names[1].Length; // 

            try
            {
                for (int i = 0; i < names.Count; i = i + 2)
                {
                    if (names[i].Length + names[i + 1].Length > sum)
                    {
                        firstUser = names[i];
                        secondUser = names[i + 1];
                        sum = names[i].Length + names[i + 1].Length;
                    }
                }
            }
            catch
            {
                if (names[names.Count-1].Length + names[names.Count -2].Length > sum)
                {
                    firstUser = names[names.Count -2];
                    secondUser = names[names.Count-1];
                    sum = names[names.Count - 2].Length + names[names.Count-1].Length;
                }
            }
            Console.WriteLine($"{firstUser}\r\n{secondUser}");
        }
    }
}
