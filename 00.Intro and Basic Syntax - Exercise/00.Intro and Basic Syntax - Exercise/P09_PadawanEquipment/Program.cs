using System;

namespace P09_PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());

            int countOfStudents = int.Parse(Console.ReadLine());

            double priceLightSaber = double.Parse(Console.ReadLine());

            double priceRobes = double.Parse(Console.ReadLine());

            double priceBelt = double.Parse(Console.ReadLine());

            double totalPriceSaber = priceLightSaber * (int)Math.Ceiling(countOfStudents * 1.1);
            double totalPriceRobes = priceRobes * countOfStudents;
            double totalPriceBelt = priceBelt * (countOfStudents - (countOfStudents / 6));

            double moneyNed = totalPriceSaber + totalPriceRobes + totalPriceBelt;

            if (moneyNed <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {moneyNed:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {moneyNed - money:f2}lv more.");
            }

        }
    }
}
