using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_MergeFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText("input1.txt", "1 3 5");
            File.WriteAllText("input2.txt", "2 4 6");


            var firstFile = File.ReadAllText("input1.txt").Split().ToArray();
            var secondFile = File.ReadAllText("input2.txt").Split().ToArray();



            for (int i = 0; i < firstFile.Length; i++)
            {
                var textToApend = $"{firstFile[i]}\r{secondFile[i]}\r";

                File.AppendAllText("result.txt", textToApend);

            }



        }
    }
}
