using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08_LogsAggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            var userLogs = new Dictionary<string, Dictionary<string, int>>(); // user, ip, duration

            var count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                var input = Console.ReadLine().Split();

                var ip = input[0];
                var user = input[1];
                var duration = int.Parse(input[2]);


                if (!userLogs.ContainsKey(user))
                {
                    userLogs.Add(user, new Dictionary<string, int>());
                }
                if (!userLogs[user].ContainsKey(ip))
                {
                    userLogs[user].Add(ip, 0);
                }

                userLogs[user][ip] += duration;
            }

            foreach (KeyValuePair<string, Dictionary<string, int>> user in userLogs.OrderBy(a => a.Key))// users
            {

                foreach (KeyValuePair<string, int> item in user.Value) // ip, duration
                {
                    Console.WriteLine($"{user.Key}: {user.Value.Values.Sum()} [{string.Join(", ", user.Value.Keys.OrderBy(a => a))}]");
                    break;
                }
               
            }
        }
    }
}
