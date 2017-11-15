using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_OddLines
{
    class OddLines
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("input.txt");

            //File.Create("oddlinestext.txt");

            var oddLines = lines.Where((line, index) => index % 2 != 0);

            File.WriteAllLines("oddlinestext.txt", oddLines);


        }
    }
}
