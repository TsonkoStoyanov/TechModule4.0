using System;
using System.Linq;

namespace P09_LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            int[] field = new int[length];

            int[] ladyBugs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();

            foreach (var ladyBugIndex in ladyBugs)
            {
                if (IsInsideField(field, ladyBugIndex))
                {
                    field[ladyBugIndex] = 1;
                }

            }

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] inputArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                int ladyBugIndex = int.Parse(inputArgs[0]);

                string command = inputArgs[1];

                int step = int.Parse(inputArgs[2]);

                if (!IsInsideField(field, ladyBugIndex))
                {
                    continue;
                }

                if (field[ladyBugIndex] != 1)
                {
                    continue;
                }

                MoveLadyBug(field, ladyBugIndex, command, step);

            }

            Console.WriteLine(string.Join(" ", field));

        }

        private static void MoveLadyBug(int[] field, int ladyBugIndex, string command, int step)
        {

            if (command == "right")
            {
                int nextStepRight = ladyBugIndex + step;

                field[ladyBugIndex] = 0;

                while (IsInsideField(field, nextStepRight))
                {
                    if (field[nextStepRight] == 0)
                    {
                        field[nextStepRight] = 1;
                        break;
                    }

                    nextStepRight += step;

                }
            }
            else
            {
                int nextStepLeft = ladyBugIndex - step;

                field[ladyBugIndex] = 0;

                while (IsInsideField(field, nextStepLeft))
                {
                    if (field[nextStepLeft] == 0)
                    {
                        field[nextStepLeft] = 1;
                        break;
                    }

                    nextStepLeft -= step;

                }
            }

        }

        private static bool IsInsideField(int[] field, int index)
        {
            if (index >= 0 && index < field.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}

