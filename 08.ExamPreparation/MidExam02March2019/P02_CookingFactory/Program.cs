using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_CookingFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            List<int> bestBreadQuality = new List<int>();

            int bestQuality = int.MinValue;

            double bestAverageQuality = Double.MinValue;
            ;

            while ((input = Console.ReadLine()) != "Bake It!")
            {
                List<int> bread = input.Split("#").Select(int.Parse).ToList();

                int quality = bread.Sum();

                double averageQuality = bread.Average();

                if (quality > bestQuality)
                {
                    bestQuality = quality;
                    bestBreadQuality.Clear();
                    bestBreadQuality.AddRange(bread);
                    bestAverageQuality = averageQuality;
                }
                else if (quality == bestQuality)
                {
                    if (bestAverageQuality < averageQuality)
                    {
                        bestQuality = quality;
                        bestBreadQuality.Clear();
                        bestBreadQuality.AddRange(bread);
                        bestAverageQuality = averageQuality;
                    }
                    else if (bestBreadQuality.Count > bread.Count)
                    {
                        bestQuality = quality;
                        bestBreadQuality.Clear();
                        bestBreadQuality.AddRange(bread);
                        bestAverageQuality = averageQuality;
                    }

                }

            }

            Console.WriteLine($"Best Batch quality: {bestQuality}");
            Console.WriteLine(string.Join(" ", bestBreadQuality));
        }
    }
}
