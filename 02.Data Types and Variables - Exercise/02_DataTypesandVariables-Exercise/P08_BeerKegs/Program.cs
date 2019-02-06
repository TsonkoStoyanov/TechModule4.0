using System;
using System.Xml.Schema;

namespace P08_BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double maxVoulume = 0; 

            string result = String.Empty;

            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();

                double radius = double.Parse(Console.ReadLine());

                int height = int.Parse(Console.ReadLine());

                double volume = Math.PI * Math.Pow(radius, 2) * height;

                if (maxVoulume < volume)
                {
                    result = model;
                    maxVoulume = volume;
                }
            }

            Console.WriteLine(result);
        }
    }
}
