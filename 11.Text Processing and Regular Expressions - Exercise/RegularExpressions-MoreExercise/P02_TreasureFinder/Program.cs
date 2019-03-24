using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace P02_TreasureFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string input = string.Empty;

            int indexNumber = 0;

            StringBuilder sb = new StringBuilder();

            while ((input = Console.ReadLine()) != "find")
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (indexNumber > numbers.Length - 1)
                    {
                        indexNumber = 0;
                    }

                    char current = (char)(input[i] - numbers[indexNumber]);
                    indexNumber++;
                    sb.Append(current);
                }

                indexNumber = 0;

                string result = sb.ToString();
                sb.Clear();

                string pattern = @"&(?<type>\w+)&.+<(?<coridinates>\w+)>";

                if (Regex.IsMatch(result, pattern))
                {
                    Match match = Regex.Match(result, pattern);
                    Console.WriteLine("Found {0} at {1}",
                        match.Groups["type"].Value,
                        match.Groups["coridinates"].Value);

                }

            }
        }
    }
}
