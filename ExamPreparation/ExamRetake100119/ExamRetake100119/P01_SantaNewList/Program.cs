using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_SantaNewList
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            Dictionary<string, int> children = new Dictionary<string, int>();

            Dictionary<string, int> toys = new Dictionary<string, int>();

            while ((input = Console.ReadLine()) != "END")
            {
                string[] inputArgs = input.Split("->");

                if (inputArgs.Length > 2)
                {

                    string childName = inputArgs[0];
                    string typeOfToy = inputArgs[1];
                    int quantity = int.Parse(inputArgs[2]);

                    if (!children.ContainsKey(childName))
                    {
                        children.Add(childName, 0);
                    }

                    children[childName] += quantity;

                    if (!toys.ContainsKey(typeOfToy))
                    {
                        toys.Add(typeOfToy, 0);
                    }

                    toys[typeOfToy] += quantity;
                }
                else
                {
                    string childNameToRemove = inputArgs[1];

                    if (children.ContainsKey(childNameToRemove))
                    {
                        children.Remove(childNameToRemove);
                    }

                }
            }

            Console.WriteLine($"Children:");

            foreach (var child in children.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{child.Key} -> {child.Value}");
            }

            Console.WriteLine($"Presents:");

            foreach (var toy in toys)
            {
                Console.WriteLine($"{toy.Key} -> {toy.Value}");
            }
        }
    }
}
