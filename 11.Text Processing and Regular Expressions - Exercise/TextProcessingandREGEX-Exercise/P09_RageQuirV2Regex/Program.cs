using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace P09_RageQuirV2Regex
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder();

            string pattern = @"((?<symbols>[^\d]+)(?<timesToRepeat>\d+))";

            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (Match match in matches)
            {
                int timesToRepeat = int.Parse(match.Groups["timesToRepeat"].Value);
                string temp = match.Groups["symbols"].Value;

                for (int i = 0; i < timesToRepeat; i++)
                {
                    sb.Append(temp.ToUpper());
                }
            }


            Console.WriteLine($"Unique symbols used: {sb.ToString().Distinct().Count()}");
            Console.WriteLine(sb);
        }
    }
}
