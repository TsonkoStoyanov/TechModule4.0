using System;
using System.Linq;

namespace P02_PresentDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] houses = Console.ReadLine().Split("@").Select(int.Parse).ToArray();

            string input = string.Empty;

            int lastPossitionSanta = 0;

            int currentIndex = 0;

            while ((input = Console.ReadLine()) != "Merry Xmas!")
            {
                string[] inputArgs = input.Split();

                int step = int.Parse(inputArgs[1]);

                currentIndex += step;

                while (currentIndex > houses.Length - 1)
                {
                    currentIndex -= houses.Length;
                }


                if (houses[currentIndex] <= 0)
                {
                    Console.WriteLine($"House {currentIndex} will have a Merry Christmas.");
                }

                houses[currentIndex] -= 2;

                lastPossitionSanta = currentIndex;

            }

            if (houses.Any(x => x > 0))
            {
                Console.WriteLine($"Santa's last position was {lastPossitionSanta}.");
                Console.WriteLine($"Santa has failed {houses.Count(x => x > 0)} houses.");
            }
            else
            {
                Console.WriteLine($"Santa's last position was {lastPossitionSanta}.");
                Console.WriteLine($"Mission was successful.");
            }
        }
    }
}
