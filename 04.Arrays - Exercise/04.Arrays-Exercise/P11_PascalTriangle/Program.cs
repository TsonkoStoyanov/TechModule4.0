using System;

namespace P11_PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j < number; j++)
                {
                    Console.Write(1);
                    Console.Write(j);
                }

                Console.WriteLine(1);
            }
        }
    }
}
