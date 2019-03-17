using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Dictionary<string, int> collections = new Dictionary<string, int>()
            {
                {"shards", 0},
                {"fragments",0 },
                {"motes", 0}
            };

            Dictionary<string, int> junks = new Dictionary<string, int>();

            bool isNotObtained = true;

            while (isNotObtained)
            {
                string[] input = Console.ReadLine().Split();

                for (int i = 0; i < input.Length - 1; i += 2)
                {
                    int currentQuantity = int.Parse(input[i]);

                    string currentResources = input[i + 1].ToLower();

                    if (collections.ContainsKey(currentResources))
                    {
                        collections[currentResources] += currentQuantity;

                        if (collections[currentResources] >= 250)
                        {
                            isNotObtained = false;

                            if (currentResources == "shards")
                            {
                                Console.WriteLine($"Shadowmourne obtained!");

                            }
                            else if (currentResources == "fragments")
                            {
                                Console.WriteLine($"Valanyr obtained!");
                            }
                            else
                            {
                                Console.WriteLine($"Dragonwrath obtained!");
                            }

                            collections[currentResources] -= 250;
                            break;
                        }
                    }
                    else
                    {
                        if (!junks.ContainsKey(currentResources))
                        {
                            junks.Add(currentResources, 0);
                        }

                        junks[currentResources] += currentQuantity;
                    }

                }
            }

            foreach (var item in collections.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            foreach (var item in junks.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
