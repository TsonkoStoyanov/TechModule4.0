using System;
using System.Collections.Generic;

namespace P03_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            var orders = new Dictionary<string, decimal[]>();

            while ((input = Console.ReadLine()) != "buy")
            {
                string[] inputArgs = input.Split();

                string product = inputArgs[0];

                decimal price = decimal.Parse(inputArgs[1]);

                decimal quantity = decimal.Parse(inputArgs[2]);

                if (!orders.ContainsKey(product))
                {
                    orders.Add(product, new decimal[2]);
                }

                orders[product][0] += quantity;
                orders[product][1] = price;

            }


            foreach (var item in orders)
            {
                decimal price = item.Value[0] * item.Value[1];

                Console.WriteLine($"{item.Key} -> {price:f2}");
            }
        }
    }
}
