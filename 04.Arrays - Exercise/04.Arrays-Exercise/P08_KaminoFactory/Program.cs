using System;
using System.Collections.Generic;
using System.Linq;

namespace P08_KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            string input = string.Empty;

            int numberOfLines = 0;

            int numbersLineToPrint = 0;

            int maxCount = 0;

            int startIndex = -1;


            int maxSum = 0;

            int leftMostIndex = int.MaxValue;

            int[] bestDna = new int[length];

            while ((input = Console.ReadLine()) != "Clone them!")
            {
                int count = 0;

                int[] currentDna = input.Split("!", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                int sum = currentDna.Sum();

                numberOfLines++;

                for (int i = 0; i < currentDna.Length; i++)
                {
                    if (currentDna[i] == 1)
                    {
                        count++;
                        startIndex = i - count + 1;
                    }

                    else
                    {
                        count = 0;
                    }

                    if (count > maxCount)
                    {
                        maxCount = count;
                        bestDna = currentDna;
                        maxSum = sum;
                        leftMostIndex = startIndex;
                        numbersLineToPrint = numberOfLines;
                    }

                    if (count == maxCount && leftMostIndex > startIndex)
                    {
                        maxCount = count;
                        bestDna = currentDna;
                        maxSum = sum;
                        leftMostIndex = startIndex;
                        numbersLineToPrint = numberOfLines;
                    }

                    if (count == maxCount && leftMostIndex == startIndex && maxSum < sum)
                    {

                        maxCount = count;
                        bestDna = currentDna;
                        maxSum = sum;
                        leftMostIndex = startIndex;
                        numbersLineToPrint = numberOfLines;

                    }


                }
            }

            Console.WriteLine($"Best DNA sample {numbersLineToPrint} with sum: {maxSum}.");

            Console.WriteLine(String.Join(" ", bestDna));
        }
    }
}
