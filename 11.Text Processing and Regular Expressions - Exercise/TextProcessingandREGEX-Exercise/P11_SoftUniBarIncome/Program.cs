using System;
using System.Text.RegularExpressions;

namespace P11_SoftUniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern =
                @"%(?<name>[A-z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<count>\d+)\|[^|$%.]*?(?<price>[0-9]+\.?[0-9]+)\$";

            string input = string.Empty;

            double sumTotalPrice = 0.00;

            while ((input = Console.ReadLine())!="end of shift")
            {
                double totalPrice = 0.0;

                if (Regex.IsMatch(input, pattern))
                {


                    Match match = Regex.Match(input, pattern);

                    string customerName = match.Groups["name"].Value;

                    string product = match.Groups["product"].Value;

                    int count = int.Parse(match.Groups["count"].Value);

                    double price = double.Parse(match.Groups["price"].Value);

                    totalPrice = count * price;

                    Console.WriteLine($"{customerName}: {product} - {totalPrice:f2}");
                }

                sumTotalPrice += totalPrice;
            }

            Console.WriteLine($"Total income: {sumTotalPrice:f2}");
        }
    }
}
