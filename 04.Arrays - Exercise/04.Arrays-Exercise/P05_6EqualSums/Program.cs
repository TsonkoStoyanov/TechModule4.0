using System;
using System.Linq;

namespace P05_EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rightSum = 0;
            int leftSum = 0;
            bool isEqual = false;

            rightSum = numbers.Sum();

            for (int i = 0; i < numbers.Length ; i++)
            {
                rightSum -= numbers[i];

                if (rightSum == leftSum)
                {
                    isEqual = true;
                    Console.WriteLine(i);
                }

                leftSum += numbers[i];
            }

            if (!isEqual)
            {
                Console.WriteLine("no");
            }
        }
    }
}
