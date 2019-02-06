using System;
using System.Collections.Generic;
using System.Linq;

namespace P07_VendingMashine
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = String.Empty;
            decimal[] aceptableMoneies = new[] { 0.1m, 0.2m, 0.5m, 1m, 2m };

            Dictionary<string, decimal> drinks = new Dictionary<string, decimal>()
            {
                { "Nuts", 2.0m},
                { "Water", 0.7m},
                { "Crisps", 1.5m},
                { "Soda", 0.8m},
                { "Coke", 1.0m},

            };

            decimal totalMoney = 0;


            while ((input = Console.ReadLine()) != "Start")
            {
                decimal money = decimal.Parse(input);

                if (aceptableMoneies.Contains(money))
                {
                    totalMoney += money;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {money}");
                }
            }


            while ((input = Console.ReadLine()) != "End")
            {
                if (!drinks.ContainsKey(input))
                {
                    Console.WriteLine("Invalid product");
                    continue;
                }

                decimal price = drinks[input];

                if (price > totalMoney)
                {
                    Console.WriteLine($"Sorry, not enough money");
                }
                else
                {
                    totalMoney -= price;
                    Console.WriteLine($"Purchased {input.ToLower()}");
                }
            }

            Console.WriteLine($"Change: {totalMoney:f2}");
        }
    }
}

