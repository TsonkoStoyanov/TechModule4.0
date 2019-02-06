using System;
using System.Collections.Generic;

namespace P13_GamingStore
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, decimal> games = new Dictionary<string, decimal>()
            {
                {"OutFall 4", 39.99m},
                { "CS: OG", 15.99m},
                {"Zplinter Zell", 19.99m},
                { "Honored 2", 59.99m},
                { "RoverWatch", 29.99m},
                {"RoverWatch Origins Edition", 39.99m }

            };


            decimal balance = decimal.Parse(Console.ReadLine());

            string input = string.Empty;

            decimal total = 0;

            while ((input = Console.ReadLine()) != "Game Time")
            {
                if (!games.ContainsKey(input))
                {
                    Console.WriteLine("Not Found");
                    continue;
                }

                if (balance == 0) 
                {
                    Console.WriteLine($"Out of money!");
                    break;
                }

                decimal price = games[input];

                if (price > balance)
                {
                    Console.WriteLine($"Too Expensive");
                    continue;
                }

                Console.WriteLine($"Bought {input}");

                total += price;
                balance -= price;
            }

            Console.WriteLine($"Total spent: ${total}. Remaining: ${balance}");
        }

        
    }
}
