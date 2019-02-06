using System;

namespace P03_Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());

            string type = Console.ReadLine();

            string day = Console.ReadLine();

            decimal price = 0.0m;
            decimal totalPrice = 0.0m;

            switch (type.ToLower())
            {
                case "students":
                    if (day.ToLower() == "friday")
                    {
                        totalPrice = 8.45m * numberOfPeople;
                    }
                    else if (day.ToLower() == "saturday")
                    {
                        totalPrice = 9.8m * numberOfPeople;
                    }
                    else
                    {
                        totalPrice = 10.46m * numberOfPeople;
                    }

                    if (numberOfPeople >= 30)
                    {
                        totalPrice *= 0.85m;
                    }
                    break;

                case "regular":
                    if (day.ToLower() == "friday")
                    {
                        totalPrice = 15 * numberOfPeople;
                    }
                    else if (day.ToLower() == "saturday")
                    {
                        totalPrice = 20m * numberOfPeople;
                    }
                    else
                    {
                        totalPrice = 22.50m * numberOfPeople;
                    }

                    if (numberOfPeople >= 10 && numberOfPeople <=20)
                    {
                        totalPrice *= 0.95m;
                    }
                    break;

                case "business":
                    if (numberOfPeople >= 100)
                    {
                        numberOfPeople -= 10;
                    }
                    if (day.ToLower() == "friday")
                    {
                        totalPrice = 10.90m * numberOfPeople;
                    }
                    else if (day.ToLower() == "saturday")
                    {
                        totalPrice = 15.60m * numberOfPeople;
                    }
                    else
                    {
                        totalPrice = 16.00m * numberOfPeople;
                    }

                    break;

            }

            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
