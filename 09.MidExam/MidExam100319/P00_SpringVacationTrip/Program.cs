using System;

namespace P00_SpringVacationTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());

            decimal budget = decimal.Parse(Console.ReadLine());

            int people = int.Parse(Console.ReadLine());

            decimal priceFuelPerKm = decimal.Parse(Console.ReadLine());

            decimal expensePerPersonDay = decimal.Parse(Console.ReadLine());

            decimal priceNightPerPerson = decimal.Parse(Console.ReadLine());

            decimal consumption = people * expensePerPersonDay * days;

            int currentDay = 0;

            if (people >= 10)
            {
                priceNightPerPerson *= 0.75m;
            }

            decimal priceNight = people * priceNightPerPerson * days;

            decimal totalExpense = priceNight + consumption;

            for (int i = 1; i <= days; i++)
            {

                decimal traveledKm = decimal.Parse(Console.ReadLine());

                decimal dayExpense = traveledKm * priceFuelPerKm;

                totalExpense += dayExpense;

                if (totalExpense > budget)
                {
                    currentDay = i;
                    break;
                }

                if (i % 3 == 0 || i % 5 == 0)
                {
                    totalExpense *= 1.4m;
                }
                if (i % 7 == 0)
                {
                    decimal someMoney = totalExpense / people;
                    totalExpense -= someMoney;
                }
            }


            if (totalExpense < budget)
            {
                Console.WriteLine($"You have reached the destination. You have {budget - totalExpense:f2}$ budget left.");

            }
            else
            {
                Console.WriteLine($"Not enough money to continue the trip. You need {totalExpense - budget:f2}$ more.");
            }

        }
    }
}

