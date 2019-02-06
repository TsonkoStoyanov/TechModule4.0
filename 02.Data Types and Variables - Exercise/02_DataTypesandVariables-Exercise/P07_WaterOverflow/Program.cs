using System;

namespace P07_WaterOverflow
{
    class Program
    {
        private static int WaterTankCapacity = 255;
        private static string Message = "Insufficient capacity!";


        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int totalLiters = 0;

            while (n > 0)
            {
                int liters = int.Parse(Console.ReadLine());

                if (WaterTankCapacity < totalLiters + liters)
                {
                    Console.WriteLine(Message);
                }
                else
                {
                    totalLiters += liters;
                }

                n--;

            }

            Console.WriteLine(totalLiters);

        }
    }
}

