using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_HelloFrance
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] items = Console.ReadLine().Split("|");

            decimal budget = decimal.Parse(Console.ReadLine());

            List<decimal> newPriceBoughtItem = new List<decimal>();

            decimal sum = 0;

            for (int i = 0; i < items.Length; i++)
            {
                string[] itemsArgs = items[i].Split("->");

                string item = itemsArgs[0];

                decimal price = decimal.Parse(itemsArgs[1]);

                if (item == "Clothes" && price <= 50.00m && budget - price >= 0)
                {
                    budget -= price;
                    sum += price;
                    newPriceBoughtItem.Add(price * 1.4m);
                }
                else if (item == "Shoes" && price <= 35.00m && budget - price >= 0)
                {
                    budget -= price;
                    sum += price;
                    newPriceBoughtItem.Add(price * 1.4m);
                }
                else if (item == "Accessories" && price <= 20.50m && budget - price >= 0)
                {
                    budget -= price;
                    sum += price;
                    newPriceBoughtItem.Add(price * 1.4m);
                }
            }

            decimal profit = newPriceBoughtItem.Sum() - sum;

            budget += newPriceBoughtItem.Sum();

            foreach (var item in newPriceBoughtItem)
            {
                Console.Write($"{item:f2} ");
            }
            Console.WriteLine();
            if (budget >= 150)
            {
                Console.WriteLine($"Profit: {profit:f2}");
                Console.WriteLine($"Hello, France!");
            }
            else
            {
                Console.WriteLine($"Profit: {profit:f2}");
                Console.WriteLine($"Time to go.");
            }

        }
    }
}
