using System;
using System.Linq;

namespace P06_MaxSequenceofEqualElementsv2
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int startIndex = 0;
            int maxCount = 0;
            int count = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    count++;

                    if (count > maxCount)
                    {
                        maxCount = count;
                        startIndex = i - count + 1;
                    }
                }
                else
                {
                    count = 0;
                }

            }


            for (int i = startIndex; i <= maxCount + startIndex; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
