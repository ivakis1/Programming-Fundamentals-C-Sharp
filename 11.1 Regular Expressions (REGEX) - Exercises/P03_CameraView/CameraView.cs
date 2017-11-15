﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace P03_CameraView
{
    class CameraView
    {
        static void Main(string[] args)
        {
            var pattern = @"(\|<\w+)";

            var possitions = Console.ReadLine().Split();
            var text = Console.ReadLine();

            var m = int.Parse(possitions[0]);
            var n = int.Parse(possitions[1]);

            var matched = new List<string>();

            MatchCollection matches = Regex.Matches(text, pattern);

            foreach ( Match item in matches)
            {              
                    matched.Add(string.Join("", item.Value.Skip(m+2).Take(n).ToArray()));              
            }

            Console.WriteLine(string.Join(", ", matched));
        }
    }
}
