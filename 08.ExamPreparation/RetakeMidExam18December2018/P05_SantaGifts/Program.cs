using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_SantaGifts
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersOfOperations = int.Parse(Console.ReadLine());

            List<int> houses = Console.ReadLine().Split().Select(int.Parse).ToList();

            int santaPosition = 0;

            for (int i = 0; i < numbersOfOperations; i++)
            {
                string[] input = Console.ReadLine().Split();

                string command = input[0];

                int steps = 0;

                switch (command)
                {
                    case "Forward":
                        steps = int.Parse(input[1]);

                        if (IsInRange(houses, steps, santaPosition))
                        {
                            santaPosition += steps;
                            houses.RemoveAt(santaPosition);
                        }


                        break;

                    case "Back":
                        steps = int.Parse(input[1]);

                        if (IsInRange(houses, -steps, santaPosition))
                        {
                            santaPosition -= steps;
                            houses.RemoveAt(santaPosition);
                        }

                        break;

                    case "Gift":
                        int index = int.Parse(input[1]);
                        int value = int.Parse(input[2]);

                        if (IsInRange(houses, index))
                        {
                            houses.Insert(index, value);
                            santaPosition = index;
                        }

                        break;

                    case "Swap":
                        int value1 = int.Parse(input[1]);
                        int value2 = int.Parse(input[2]);
                        Swap(houses, value1, value2);


                        break;

                }

            }

            Console.WriteLine($"Position: {santaPosition}");

            Console.WriteLine(string.Join(", ", houses));

        }

        private static void Swap(List<int> houses, int value1, int value2)
        {
            int firstIndex = houses.IndexOf(value1);
            int secondIndex = houses.IndexOf(value2);

            if (IsInRange(houses, firstIndex) && IsInRange(houses, secondIndex))
            {
                int temp = houses[firstIndex];
                houses[firstIndex] = houses[secondIndex];
                houses[secondIndex] = temp;
            }



        }

        private static bool IsInRange(List<int> houses, int index)
        {
            if (index >= 0 && index < houses.Capacity)
            {
                return true;
            }

            return false;
        }

        private static bool IsInRange(List<int> houses, int steps, int santaPosition)
        {
            if (steps + santaPosition >= 0 && steps + santaPosition < houses.Capacity)
            {
                return true;
            }

            return false;
        }
    }
}
