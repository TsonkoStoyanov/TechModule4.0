using System;
using System.Linq;

namespace P02_Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            int[] firstAray = new int[numberOfLines];
            int[] secondAray = new int[numberOfLines];



            for (int i = 0; i < numberOfLines; i++)
            {
                int[] number = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (i % 2 == 0)
                {
                    firstAray[i] = number[0];
                    secondAray[i] = number[1];
                }
                else
                {
                    firstAray[i] = number[1];
                    secondAray[i] = number[0];
                }
            }

            Console.WriteLine(string.Join(" ", firstAray));
            Console.WriteLine(string.Join(" ", secondAray));
        }
    }
}
