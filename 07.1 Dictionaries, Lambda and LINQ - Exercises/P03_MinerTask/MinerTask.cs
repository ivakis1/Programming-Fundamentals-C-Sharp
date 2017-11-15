using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_MinerTask
{
   public class MinerTask
    {
       public static void Main()
        {
            var resources = new Dictionary<string, int>();

            for (int i = 1; ; i++)
            {
                var material = Console.ReadLine();

                if (material == "stop")
                {
                    foreach (var item in resources)
                    {
                        Console.WriteLine($"{item.Key} -> {item.Value}");
                    }
                    return;
                }

                var quantity = int.Parse(Console.ReadLine());              

                if (!resources.ContainsKey(material))
                {
                    resources[material] = quantity;
                }
                else
                {
                    resources[material] += quantity;
                }


            }
        }
    }
}
