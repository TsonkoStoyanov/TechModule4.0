using System;
using System.Collections.Generic;

namespace P01_AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            Dictionary<string, int> resources = new Dictionary<string, int>();

            while ((input = Console.ReadLine()) != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (!resources.ContainsKey(input))
                {
                    resources.Add(input, 0);
                }

                resources[input] += quantity;
            }

            foreach (var item in resources)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
