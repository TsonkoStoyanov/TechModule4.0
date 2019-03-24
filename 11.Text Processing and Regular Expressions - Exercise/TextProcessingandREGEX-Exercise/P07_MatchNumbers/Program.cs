using System;
using System.Text.RegularExpressions;

namespace P07_MatchNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";

            string input = Console.ReadLine();

            MatchCollection matched = Regex.Matches(input, regex);

            foreach (Match match in matched)
            {
                Console.Write(match.Value + " ");
            }

            Console.WriteLine();
        }
    }
}
