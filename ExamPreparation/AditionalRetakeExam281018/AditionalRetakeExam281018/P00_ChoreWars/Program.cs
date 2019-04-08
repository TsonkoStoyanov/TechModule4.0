using System;
using System.Text.RegularExpressions;

namespace P00_ChoreWars
{
    class Program
    {
        static void Main(string[] args)
        {
            string dishesPattern = @"<([a-z0-9]*)>";
            string cleaningPattern = @"\[([A-Z0-9]*)\]";
            string laundryPattern = @"\{(.*)\}";

            string input = string.Empty;

            int timeDishes = 0;
            int timeCleaning = 0;
            int timeLaundry = 0;

            int totalTime = 0;

            while ((input = Console.ReadLine()) != "wife is happy")
            {
                if (Regex.IsMatch(input, dishesPattern))
                {
                    Match match = Regex.Match(input, dishesPattern);
                    int time = CalculateTime(match.Groups[1].Value);
                    timeDishes += time;
                    
                }
                else if (Regex.IsMatch(input, cleaningPattern))
                {
                    Match match = Regex.Match(input, cleaningPattern);
                    int time = CalculateTime(match.Groups[1].Value);
                    timeCleaning += time;
                    
                }
                else if (Regex.IsMatch(input, laundryPattern))
                {
                    Match match = Regex.Match(input, laundryPattern);
                    int time = CalculateTime(match.Groups[1].Value);
                    timeLaundry += time;
                    
                }
            }

            totalTime = timeDishes + timeCleaning + timeLaundry;

            Console.WriteLine($"Doing the dishes - {timeDishes} min.");
            Console.WriteLine($"Cleaning the house - {timeCleaning} min.");
            Console.WriteLine($"Doing the laundry - {timeLaundry} min.");
            Console.WriteLine($"Total - {totalTime} min.");
        }

        private static int CalculateTime(string value)
        {
            int result = 0;

            for (int i = 0; i < value.Length; i++)
            {
                if (Char.IsDigit(value[i]))
                {
                    result += (value[i] - 48);
                }
            }

            return result;
        }
    }
}
