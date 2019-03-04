using System;

namespace P00_CookingMasterclass
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());

            decimal students = decimal.Parse(Console.ReadLine());

            decimal flourPrice = decimal.Parse(Console.ReadLine());

            decimal eggPrice = decimal.Parse(Console.ReadLine());

            decimal apronPrice = decimal.Parse(Console.ReadLine());


            decimal freeFlour = 0m;

            if (students >= 5)
            {
                freeFlour = (int)students / 5;
            }

            decimal flours = flourPrice * (students - freeFlour);

            decimal eggs = students * 10 * eggPrice;

            decimal aprons = Math.Ceiling(students * 1.2m) * apronPrice;

            decimal moneyNeed = flours + aprons + eggs;

            if (budget >= moneyNeed)
            {
                Console.WriteLine($"Items purchased for {moneyNeed:f2}$.");
            }
            else
            {
                Console.WriteLine($"{moneyNeed - budget:f2}$ more needed.");
            }
        }
    }
}
