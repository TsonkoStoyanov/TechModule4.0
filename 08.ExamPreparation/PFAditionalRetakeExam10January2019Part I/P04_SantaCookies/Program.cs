using System;
using System.Xml;

namespace P04_SantaCookies
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfBatches = int.Parse(Console.ReadLine());

            int singleCookieGrams = 25;

            int cup = 140;
            int smallSpoon = 10;
            int bigSpoon = 20;

            int totalBoxes = 0;

            //Cookies per Box	5


            for (int i = 0; i < numberOfBatches; i++)
            {
                int flourInGrams = int.Parse(Console.ReadLine());
                int sugarInGrams = int.Parse(Console.ReadLine());
                int cоcоаInGrams = int.Parse(Console.ReadLine());

                int flourCups = flourInGrams / cup;

                int sugarSpoons = sugarInGrams / bigSpoon;

                int cocoaSpoons = cоcоаInGrams / smallSpoon;

                if (flourCups <= 0 || sugarSpoons <= 0 || cocoaSpoons <= 0)
                {
                    Console.WriteLine($"Ingredients are not enough for a box of cookies.");
                    continue;
                }

                var min = Math.Min(flourCups, Math.Min(cocoaSpoons, sugarSpoons));

                var cookies = ((cup + smallSpoon + bigSpoon) * min)/singleCookieGrams;

                var boxes = cookies / 5;

                totalBoxes += boxes;

                Console.WriteLine($"Boxes of cookies: {boxes}");
            }

            Console.WriteLine($"Total boxes: {totalBoxes}");
        }
    }
}
