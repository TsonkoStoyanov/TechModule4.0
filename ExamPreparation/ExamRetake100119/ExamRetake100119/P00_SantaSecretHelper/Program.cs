using System;
using System.Text;
using System.Text.RegularExpressions;

namespace P00_SantaSecretHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());

            string input = string.Empty;

            string pattern = @"@(?<name>[A-Za-z]+)[^@\-!:>]*!(?<behavior>G|N)!";
            

            while ((input = Console.ReadLine()) != "end")
            {
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < input.Length; i++)
                {
                    sb.Append((char)(input[i] - key));
                }

                var result = sb.ToString();

                if (Regex.IsMatch(result, pattern))
                {
                    Match match = Regex.Match(result, pattern);

                    if (match.Groups["behavior"].Value == "G")
                    {
                        Console.WriteLine(match.Groups["name"].Value);
                    }
                }
            }
        }
    }
}
