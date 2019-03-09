using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_GrainsofSands
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> grains = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Mort")
            {
                string[] inputArgs = input.Split();

                string command = inputArgs[0];

                int value = int.Parse(inputArgs[1]);

                int index = 0;

                switch (command)
                {
                    case "Add":
                        grains.Add(value);
                        break;

                    case "Remove":

                        index = grains.IndexOf(value);

                        if (index == -1)
                        {
                            if (IsValidIndex(grains, value))
                            {
                                grains.RemoveAt(value);
                            }
                        }
                        else
                        {
                            grains.Remove(value);
                        }
                        break;

                    case "Replace":

                        int replacement = int.Parse(inputArgs[2]);
                        index = grains.IndexOf(value);

                        if (index != -1)
                        {
                            grains[index] = replacement;

                        }
                        break;

                    case "Increase":

                        index = grains.FindIndex(x => x >= value);
                        int increaseValue = 0;

                        if (index == -1)
                        {
                            increaseValue = grains[grains.Count - 1];
                            IncreaseGrains(grains, increaseValue);
                        }
                        else
                        {
                            increaseValue = grains[index];
                            IncreaseGrains(grains, increaseValue);

                        }
                        break;

                    case "Collapse":

                        grains.RemoveAll(x => x < value);

                        break;

                }
            }

            Console.WriteLine(string.Join(" ", grains));
        }

        private static void IncreaseGrains(List<int> grains, int increaseValue)
        {
            for (int i = 0; i < grains.Count; i++)
            {
                grains[i] += increaseValue;
            }
        }

        private static bool IsValidIndex(List<int> grains, int value)
        {

            if (value >= 0 && value < grains.Count)
            {
                return true;
            }

            return false;
        }
    }
}
