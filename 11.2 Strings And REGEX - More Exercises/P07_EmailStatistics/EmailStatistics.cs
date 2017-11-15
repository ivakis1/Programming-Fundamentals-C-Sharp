using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace P07_EmailStatistics
{
    class EmailStatistics
    {
        static void Main(string[] args)
        {
            var pattern = @"^([A-Za-z]{5,})@([a-z]{3,}\.(com|bg|org))$";

            var meilLog = new Dictionary<string, List<string>>(); // host, list of users

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();

                var matchMeil = Regex.Match(input, pattern);

                if (matchMeil.Success)
                {
                    var host = matchMeil.Groups[2].Value;
                    var user = matchMeil.Groups[1].Value;

                    if (!meilLog.ContainsKey(host))
                    {
                        meilLog.Add(host, new List<string>());
                    }
                    if (!meilLog[host].Contains(user))
                    {
                        meilLog[host].Add(user);
                    }
                }
            }

            foreach (KeyValuePair<string, List<string>> host in meilLog
                .OrderByDescending(a => a.Value.Count))            
            {
                Console.WriteLine(host.Key + ":");               

                foreach (var user in host.Value)
                {
                    Console.WriteLine($"### {user}");
                }
            }
            
        }
    }
}
