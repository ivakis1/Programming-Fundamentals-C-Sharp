using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09_LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            var materials = new Dictionary<string, int>();
            var keyMaterials = new Dictionary<string, int>();

            var cicle = true;
            while (cicle)
            {
                var input = Console.ReadLine().Split().ToArray();

                for (int j = 0; j < input.Length; j++)
                {
                    var material = string.Empty;
                    var quantity = 0;
                    if (j % 2 != 0)
                    {
                        material = input[j];
                    }
                    else
                    {
                        quantity = int.Parse(input[0]);

                    }
                    if (!materials.ContainsKey(material))
                    {
                        materials.Add(material, 0);
                    }

                    if ((material == "shards" && !(keyMaterials.ContainsKey("shards")))
                        || (material == "fragments") && !(keyMaterials.ContainsKey("fragments"))
                        || (material == "motes") && !(keyMaterials.ContainsKey("motes")))
                    {
                        keyMaterials.Add(material, 0);
                    }

                    if (materials.ContainsKey("shards") && materials["shards"] >= 250)
                    {
                        Console.WriteLine($"Shadowmourne obtained!");

                        keyMaterials["shards"] = keyMaterials["shards"] - 250;

                        cicle = false;

                        break;

                    }
                    else if (materials.ContainsKey("fragments") && materials["fragments"] >= 250)
                    {
                        Console.WriteLine($"Valanyr obtained!");

                        keyMaterials["fragments"] = keyMaterials["fragments"] - 250;

                        cicle = false;

                        break;
                    }
                    else if (materials.ContainsKey("motes") && materials["motes"] >= 250)
                    {
                        Console.WriteLine($"Dragonwrath  obtained!");

                        keyMaterials["motes"] = keyMaterials["motes"] - 250;

                        cicle = false;

                        break;
                    }

                    if (material == "shards" || material == "fragments" || material == "motes")
                    {
                        keyMaterials[material] += quantity;
                    }

                    materials[material] += quantity;
                }
            }
            foreach (var item in keyMaterials.OrderByDescending(x => x.Value).ThenBy(a => a.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");

            }
            materials.Remove("motes");
            materials.Remove("fragments");
            materials.Remove("shards");

            foreach (var item in materials.OrderBy(a => a.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
