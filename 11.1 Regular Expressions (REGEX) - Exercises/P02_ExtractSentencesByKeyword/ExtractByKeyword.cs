using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace P02_ExtractSentencesByKeyword
{
    class ExtractByKeyword
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            // var pattern = $@"\b[\w\/\\, \-]+\b{input}\b[\w\/\\, \-]+\b";

            var pattern = $@"\b{input}\b";


            var text = Console.ReadLine().Split('.', '!', '?');

            foreach (var item in text)
            {
                Match sentences = Regex.Match(item, pattern);

                if (sentences.Success)
                {
                    Console.WriteLine(string.Join("\r\n", item));

                }

            }


        }
    }
}
