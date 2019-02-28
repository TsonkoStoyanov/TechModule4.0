using System;
using System.Linq;

namespace P11_CarRace
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            double left = 0;
            double right = 0;


            for (int i = 0; i < numbers.Length / 2; i++)
            {
                if (numbers[i] == 0)
                {
                    left *= 0.8;
                }
                else
                {
                    left += numbers[i];
                }

                if (numbers[numbers.Length - 1 - i] == 0)
                {
                    right *= 0.8;
                }
                else
                {
                    right += numbers[numbers.Length - 1 - i];
                }
            }

            if (left < right)
            {
                Console.WriteLine($"The winner is left with total time: {left}");
            }
            else if (right < left)
            {
                Console.WriteLine($"The winner is right with total time: {right}");
            }
        }
    }
}
