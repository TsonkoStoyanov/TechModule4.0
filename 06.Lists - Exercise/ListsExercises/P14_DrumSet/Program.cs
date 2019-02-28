using System;
using System.Linq;

namespace P14_DrumSet
{
    class Program
    {
        static void Main(string[] args)
        {
            double savings = double.Parse(Console.ReadLine());

            int[] drums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string input = string.Empty;

            int[] initialQuality = new int[drums.Length];

            bool isEnoughMoney = true;

            Array.Copy(drums, initialQuality, drums.Length);

            while ((input = Console.ReadLine()) != "Hit it again, Gabsy!")
            {
                int hitPower = int.Parse(input);

                for (int i = 0; i < drums.Length; i++)
                {
                    drums[i] -= hitPower;

                    if (drums[i] <= 0)
                    {
                        double price = initialQuality[i] * 3;

                        if (!(savings - price <= 0))
                        {
                            
                            drums[i] = initialQuality[i];
                            savings -= price;
                        }
                      
                    }
                }
            }

            Console.WriteLine(string.Join(" ", drums.Where(x => x > 0)));
            Console.WriteLine($"Gabsy has {savings:f2}lv.");
        }
    }
}
