using System;
using System.Linq;

namespace P00_Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfWagons = int.Parse(Console.ReadLine());

            int[] train = new int[numberOfWagons];

            for (int i = 0; i < numberOfWagons; i++)
            {
                train[i] = int.Parse(Console.ReadLine());

            }

            Console.WriteLine(String.Join(" ", train));
            Console.WriteLine(train.Sum());
        }
    }
}
