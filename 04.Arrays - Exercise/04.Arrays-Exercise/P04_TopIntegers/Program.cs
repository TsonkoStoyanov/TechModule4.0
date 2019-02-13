using System;
using System.Linq;

namespace P04_TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < integers.Length; i++)
            {
                bool isBigger = true;
                int number = integers[i];

                for (int j = i + 1; j < integers.Length; j++)
                {
                    if (number <= integers[j])
                    {
                        isBigger = false;
                        break;
                    }

                }

                if (isBigger)
                {

                    Console.Write(number + " ");
                }

            }

            Console.WriteLine();
        }
    }
}
