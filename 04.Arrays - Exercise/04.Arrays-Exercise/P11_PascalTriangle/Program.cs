using System;

namespace P11_PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());


            for (int i = 0; i < number; i++)
            {
                int value = 1;

                for (int j = 0; j <= i; j++)
                {
                    Console.Write(value + " ");

                    value = value * (i - j) / (j + 1);
                }

                Console.WriteLine();
            }






        }
    }
}
