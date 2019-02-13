using System;
using System.Linq;

namespace P06_MaxSequenceofEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int startIndex = 0;
            int maxCount = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int count = 0;


                int number = numbers[i];

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (number == numbers[j])
                    {
                        count++;
                        i = j - count;
                    }
                    else
                    {
                        break;
                    }
                }

                if (maxCount < count)
                {
                    maxCount = count;
                    startIndex = i;
                }

            }

            for (int i = startIndex; i <= startIndex + maxCount; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine();

        }
    }
}
