using System;
using System.Text.RegularExpressions;

namespace P00_ExtractPersonInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersOfInput = int.Parse(Console.ReadLine());

            string namePattern =@"@(?<name>[A-Za-z0-9]+)";
            string agePattern = @"#(?<age>[0-9]+)\*";

            for (int i = 0; i < numbersOfInput; i++)
            {
                string input = Console.ReadLine();

                Match matchName = Regex.Match(input, namePattern);
                Match matchAge = Regex.Match(input, agePattern);


                string name = matchName.Groups["name"].Value;

                int age = int.Parse(matchAge.Groups["age"].Value);

                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}
