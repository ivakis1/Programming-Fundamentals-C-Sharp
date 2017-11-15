using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace P07_QueryMess
{
    class QueryMess
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var pattern = @"(?<key>[^&\?][a-z0-9\*\-\._]+)=(?<value>[a-z0-9\*\-\._]+)";

            var queries = new Dictionary<string, List<string>>();

            while (input != "END")
            {
                MatchCollection matches = Regex.Matches(input, pattern);

                foreach (Match match in matches)
                {
                    var keyValuePair = match.Value.Split('=').ToArray();
                    keyValuePair.Select(a => Regex.Replace(a, @"[\+]+", " "));
                    keyValuePair.Select(a => Regex.Replace(a, @"(\%20)+", " "));

                    var key = keyValuePair[0];
                    var value = keyValuePair[1];

                    if (!queries.ContainsKey(key))
                    {
                        queries.Add(key, new List<string>() { value });
                    }
                    else if (queries.ContainsKey(key))
                    {
                        queries[key].Add(value);
                    }
                }
                input = Console.ReadLine();
            }

            foreach (var item in queries)
            {
                Console.Write(item.Key + "=");
                Console.Write("["+ string.Join(", ", item.Value)+"]");
                Console.WriteLine();


            }
        }
    }
}
