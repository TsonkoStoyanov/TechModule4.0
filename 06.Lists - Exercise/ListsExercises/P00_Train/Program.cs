using System;
using System.Collections.Generic;
using System.Linq;

namespace P00_Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> train = Console.ReadLine().Split().Select(int.Parse).ToList();

            int maxCapacityEachWagon = int.Parse(Console.ReadLine());

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] inputArgs = input.Split();

                if (inputArgs.Length > 1)
                {
                    int wagon = int.Parse(inputArgs[1]);
                    train.Add(wagon);

                }
                else
                {
                    int passengers = int.Parse(input);
                    AddPassenger(train, passengers, maxCapacityEachWagon);
                }

            }

            Console.WriteLine(string.Join(" ", train));
        }

        private static void AddPassenger(List<int> train, int passengers, int maxCapacityEachWagon)
        {

            for (int i = 0; i < train.Count; i++)
            {
                if (passengers == 0)
                {
                    break;
                }

                if (train[i] + passengers <= maxCapacityEachWagon)
                {
                    train[i] += passengers;
                    passengers = 0;
                }
            }
        }
    }
}
