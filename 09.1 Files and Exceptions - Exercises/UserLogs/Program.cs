using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            var users = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; ; i++)
            {
                var input = Console.ReadLine().Split();

                if (input[0] == "end")
                {
                    break;
                }

                string ip = input[0].Replace("IP=", "");
                string message = input[1].Replace("message=", "");
                string user = input[2].Replace("user=", "");

                //if (!users.ContainsKey(user))
                //{
                //    users.Add(user, new Dictionary<string, int>());
                //}

                //if (!users[user].ContainsKey(ip))
                //{
                //    users[user].Add(ip, 0);
                //}

               // users[user][ip] += 1;

                if (!users.ContainsKey(user))
                {
                    if (users[user].ContainsKey(ip))
                    {
                        users[user][ip] = users[user][ip] + 1;
                    }
                    else
                    {
                        users[user].Add(ip, 1);
                    }
                }
                else
                {
                    users.Add(user, new Dictionary<string, int>());
                    users[user].Add(ip, 1);
                }
          
            }

            foreach (KeyValuePair<string, Dictionary<string, int>> item in users.OrderBy(a => a.Key))
            {
                Console.WriteLine(item.Key + ": ");

                StringBuilder sb = new StringBuilder();

                foreach (KeyValuePair<string, int> ips in item.Value)
                {
                    sb.Append(ips.Key + " => " + ips.Value + ", ");

                }
                sb.Remove(sb.Length - 2, 2);
                sb.Append(".");

                Console.WriteLine(sb);
            }
        }
    }
}
