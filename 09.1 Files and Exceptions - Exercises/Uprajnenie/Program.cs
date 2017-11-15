using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uprajnenie
{
    class Program
    {
        static void Main(string[] args)
        {
            var dic = new SortedDictionary<string, Dictionary<string, int>>(); // user, ip, count


            while (true)
            {
                var input = Console.ReadLine().Split();

                if (input[0] == "end")
                {
                    break;
                }

                var ip = input[0].Replace("IP=", "");
                var user = input[2].Replace("user=", "");

                if (!dic.ContainsKey(user))
                {
                    dic.Add(user, new Dictionary<string, int>());
                }
                if (!dic[user].ContainsKey(ip))
                {
                    dic[user].Add(ip, 0);
                }

                dic[user][ip] = dic[user][ip] + 1; // dic[ip][user] += 1

            }

            foreach (KeyValuePair<string, Dictionary<string, int>> item in dic) // user
            {

                Console.WriteLine($"{item.Key}: ");

                StringBuilder sb = new StringBuilder();

                foreach (KeyValuePair<string, int> count in item.Value) // ip, count
                {
                    sb.Append(count.Key + " => " + count.Value + ", ");
                }

                sb.Remove(sb.Length - 2, 2);
                sb.Append(".");

                Console.WriteLine(sb);
            }

        }
    }
}
