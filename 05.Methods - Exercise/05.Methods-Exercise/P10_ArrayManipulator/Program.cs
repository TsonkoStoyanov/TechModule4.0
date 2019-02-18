using System;
using System.Collections.Generic;
using System.Linq;

namespace P10_ArrayManipulator
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] inputArgs = input.Split();

                string command = inputArgs[0];

                switch (command)
                {
                    case "exchange":
                        int index = int.Parse(inputArgs[1]);
                        array = Exchange(array, index);
                        break;

                    case "max":
                        string oddOrEven = inputArgs[1];
                        Max(array, oddOrEven);
                        break;

                    case "min":
                        oddOrEven = inputArgs[1];
                        Min(array, oddOrEven);
                        break;

                    case "first":
                        int count = int.Parse(inputArgs[1]);
                        oddOrEven = inputArgs[2];
                        First(array, count, oddOrEven);
                        break;

                    case "last":
                        count = int.Parse(inputArgs[1]);
                        oddOrEven = inputArgs[2];
                        Last(array, count, oddOrEven);
                        break;

                }

            }

            PrintArray(array);
        }

        private static void Last(int[] array, int count, string oddOrEven)
        {
            int index = 0;


            if (count<0||count>array.Length)
            {
                Console.WriteLine($"Invalid count");
                return;
            }

            int[] temp = new int[count];

            if (oddOrEven == "odd")
            {

                for (int i = array.Length - 1; i >= 0; i--)
                {
                    if (index == count)
                    {
                        break;
                    }

                    if (array[i] % 2 != 0)
                    {
                        temp[index] = array[i];
                        index++;
                    }

                }

            }
            if (oddOrEven == "even")
            {
                for (int i = array.Length - 1; i >= 0; i--)
                {
                    if (index == count)
                    {
                        break;
                    }

                    if (array[i] % 2 == 0)
                    {
                        temp[index] = array[i];
                        index++;
                    }

                }
            }

            if (index != 0)
            {
                int[] final = new int[index];

                for (int i = 0; i < final.Length; i++)
                {
                    final[i] = temp[i];
                }
                Array.Reverse(final);

                PrintArray(final);
            }
            else
            {
                Console.WriteLine("[]");
            }

        }

        private static void First(int[] array, int count, string oddOrEven)
        {
            int index = 0;

            if (count<0||count>array.Length)
            {
                Console.WriteLine($"Invalid count");
                return;
            }

            int[] temp = new int[count];

            if (oddOrEven == "odd")
            {

                for (int i = 0; i < array.Length; i++)
                {
                    if (index == count)
                    {
                        break;
                    }

                    if (array[i] % 2 != 0)
                    {
                        temp[index] = array[i];
                        index++;
                    }

                }

            }

            if (oddOrEven == "even")
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (index == count)
                    {
                        break;
                    }

                    if (array[i] % 2 == 0)
                    {
                        temp[index] = array[i];
                        index++;
                    }

                }
            }

            if (index != 0)
            {
                int[] final = new int[index];

                for (int i = 0; i < final.Length; i++)
                {
                    final[i] = temp[i];
                }

                PrintArray(final);
            }
            else
            {
                Console.WriteLine("[]");
            }

        }

        private static void Min(int[] array, string oddOrEven)
        {
            int minValue = int.MaxValue;
            int index = -1;

            if (oddOrEven == "odd")
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 != 0)
                    {
                        if (array[i] <= minValue)
                        {
                            minValue = array[i];
                            index = i;
                        }

                    }
                }
            }
            else if (oddOrEven == "even")
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 0)
                    {
                        if (array[i] <= minValue)
                        {
                            minValue = array[i];
                            index = i;
                        }
                    }
                }
            }

            if (index == -1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(index);
            }

        }

        private static void Max(int[] array, string oddOrEven)
        {

            int maxValue = int.MinValue;
            int index = -1;

            if (oddOrEven == "odd")
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 != 0)
                    {
                        if (array[i] >= maxValue)
                        {
                            maxValue = array[i];
                            index = i;
                        }
                    }
                }
            }
            else if (oddOrEven == "even")
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 0)
                    {
                        if (array[i] >= maxValue)
                        {
                            maxValue = array[i];
                            index = i;
                        }
                    }
                }
            }

            if (index == -1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(index);
            }
        }

        private static void PrintArray(int[] array)
        {
            Console.WriteLine($"[{string.Join(", ", array)}]");
        }

        private static int[] Exchange(int[] array, int index)
        {

            if (!IsInside(array, index))
            {
                Console.WriteLine($"Invalid index");
                return array;
            }

            int[] first = array.Take(index + 1).ToArray();

            int[] second = array.Skip(index + 1).ToArray();

            int[] temp = second.Concat(first).ToArray();

            return temp;
        }

        private static bool IsInside(int[] array, int index)
        {
            if (index < 0 || index >= array.Length)
            {
                return false;
            }

            return true;
        }
    }
}
