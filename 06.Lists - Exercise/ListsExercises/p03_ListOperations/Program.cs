using System;
using System.Collections.Generic;
using System.Linq;

namespace p03_ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();


            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] inputArgs = input.Split();
                string command = inputArgs[0];
                int number = 0;
                int index = 0;

                switch (command)
                {
                    case "Add":
                        number = int.Parse(inputArgs[1]);
                        numbers.Add(number);
                        break;

                    case "Insert":
                        number = int.Parse(inputArgs[1]);
                        index = int.Parse(inputArgs[2]);

                        if (index < 0 || index > numbers.Count)
                        {
                            Console.WriteLine($"Invalid index");
                        }
                        else
                        {
                            numbers.Insert(index, number);
                        }
                        break;

                    case "Remove":
                        index = int.Parse(inputArgs[1]);

                        if (index < 0 || index > numbers.Count)
                        {
                            Console.WriteLine($"Invalid index");
                        }
                        else
                        {
                            numbers.RemoveAt(index);
                        }
                        break;

                    case "Shift":
                        string direction = inputArgs[1];
                        int count = int.Parse(inputArgs[2]);

                        if (direction == "right")
                        {
                            ShiftRigth(numbers, count);

                        }
                        else if (direction == "left")
                        {
                            ShiftLeft(numbers, count);
                        }
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }

        private static void ShiftLeft(List<int> numbers, int count)
        {
            for (int i = 0; i < count % numbers.Count; i++)
            {

                int temp = numbers[0];

                for (int j = 0; j < numbers.Count - 1; j++)
                {
                    numbers[j] = numbers[j + 1];
                }

                numbers[numbers.Count - 1] = temp;
            }
        }

        private static void ShiftRigth(List<int> numbers, int count)
        {
            for (int i = 0; i < count % numbers.Count; i++)
            {
               
                int temp = numbers[numbers.Count - 1];

                for (int j = numbers.Count - 1; j > 0; j--)
                {
                    numbers[j] = numbers[j - 1];
                }

                numbers[0] = temp;
            }
        }
    }
}
