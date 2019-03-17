using System;
using System.Collections.Generic;
using System.Linq;

namespace P08_ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            Dictionary<string, string> usersWithSides = new Dictionary<string, string>();


            while ((input = Console.ReadLine()) != "Lumpawaroo")
            {
                string side = string.Empty;
                string user = string.Empty;

                string[] inputArgs = new string[2];

                if (input.Contains("|"))
                {
                    inputArgs = input.Split(" | ");
                    side = inputArgs[0];
                    user = inputArgs[1];

                    if (!usersWithSides.ContainsKey(user))
                    {
                        usersWithSides.Add(user, side);
                    }

                }
                else if (input.Contains("->"))
                {
                    inputArgs = input.Split(" -> ");
                    side = inputArgs[1];
                    user = inputArgs[0];


                    if (!usersWithSides.ContainsKey(user))
                    {
                        usersWithSides.Add(user, side);

                        Console.WriteLine($"{user} joins the {side} side!");
                    }
                    else
                    {
                        usersWithSides[user] = side;

                        Console.WriteLine($"{user} joins the {side} side!");

                    }

                }

            }

            var result = usersWithSides.GroupBy(x => x.Value)
                .ToDictionary(y => y.Key, y => y.Select(x => x.Key).ToList());


            foreach (var item in result.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine($"Side: {item.Key}, Members: {item.Value.Count}");

                foreach (var user in item.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"! {user}");
                }
            }

        }
    }
}
