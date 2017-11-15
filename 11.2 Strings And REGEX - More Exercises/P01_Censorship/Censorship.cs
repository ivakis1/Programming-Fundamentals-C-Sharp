using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_Censorship
{
    class Censorship
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();

            var text = Console.ReadLine();
            
            foreach (var item in text)
            {
                if (text.Contains(word))
                {
                    text = text.Replace(word, new string('*', word.Length));
                }
            }
            Console.WriteLine(text);
        }
    }
}
