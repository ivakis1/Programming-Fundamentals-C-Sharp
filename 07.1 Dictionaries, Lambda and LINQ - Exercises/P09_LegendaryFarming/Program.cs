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

            keyMaterials.Add("motes", 0);
            keyMaterials.Add("fragments", 0);
            keyMaterials.Add("shards", 0);


            for (int i = 0; i < 10; i++)
            {
                var input = Console.ReadLine().Split(); // list of materials and quantities

                for (int j = 0; j < input.Length; j = j + 2)
                {
                    var material = "";
                    var quantity = 0;

                    quantity = int.Parse(input[j]);
                    material = input[j + 1].ToLower();

                    if (materials.ContainsKey("motes") && materials["motes"] >= 250
                        || materials.ContainsKey("fragments") && materials["fragments"] >= 250
                        || materials.ContainsKey("shards") && materials["shards"] >= 250)
                    {
                        break;
                    }

                    if (!materials.ContainsKey(material))
                    {
                        materials.Add(material, 0);
                    }

                    if (material == "shards" || material == "fragments" || material == "motes")
                    {
                        keyMaterials[material] += quantity;
                    }

                    materials[material] += quantity;

                    quantity = 0;
                    material = "";
                }

                if (materials.ContainsKey("shards") && materials["shards"] >= 250)
                {
                    Console.WriteLine($"Shadowmourne obtained!");

                    keyMaterials["shards"] = keyMaterials["shards"] - 250;

                    break;

                }
                else if (materials.ContainsKey("fragments") && materials["fragments"] >= 250)
                {
                    Console.WriteLine($"Valanyr obtained!");

                    keyMaterials["fragments"] = keyMaterials["fragments"] - 250;

                    break;
                }
                else if (materials.ContainsKey("motes") && materials["motes"] >= 250)
                {
                    Console.WriteLine($"Dragonwrath obtained!");

                    keyMaterials["motes"] = keyMaterials["motes"] - 250;

                    break;
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
