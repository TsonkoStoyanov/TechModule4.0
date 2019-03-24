using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace P08_StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());

            List<string> attackedPlanet = new List<string>();
            List<string> destroyedPlanet = new List<string>();

            for (int i = 0; i < numberOfInputs; i++)
            {

                string input = Console.ReadLine();
                int descriptionKey = ExtractDescriptionKey(input);
                string decryptedMessage = DecryptMessage(input, descriptionKey);

                string regex =
                    @"@(?<planet>[A-Za-z]+)([^@:!\->]*):(?<population>[0-9]+)([^@:!\->]*)!(?<typeOfAttack>(A|D))!([^@:!\->]*)->(?<soldiers>[0-9]+)";

                if (!Regex.IsMatch(decryptedMessage, regex))
                {
                    continue;
                }

                Match match = Regex.Match(decryptedMessage, regex);

                if (match.Groups["typeOfAttack"].Value == "D")
                {
                    destroyedPlanet.Add(match.Groups["planet"].Value);
                }
                else if (match.Groups["typeOfAttack"].Value == "A")
                {
                    attackedPlanet.Add(match.Groups["planet"].Value);
                }
            }

            Console.WriteLine($"Attacked planets: {attackedPlanet.Count}");
            foreach (var planet in attackedPlanet.OrderBy(x=>x))
            {
                Console.WriteLine($"-> {planet}");
            }

            Console.WriteLine($"Destroyed planets: {destroyedPlanet.Count}");

            foreach (var planet in destroyedPlanet.OrderBy(x=>x))
            {
                Console.WriteLine($"-> {planet}");
            }
        }

        private static string DecryptMessage(string input, int descriptionKey)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                sb.Append((char)(input[i] - descriptionKey));
            }

            return sb.ToString();
        }

        private static int ExtractDescriptionKey(string input)
        {
            int count = 0;
            string temp = input.ToLower();

            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] == 's' || temp[i] == 't' || temp[i] == 'a' || temp[i] == 'r')
                {
                    count++;
                }
            }

            return count;
        }
    }
}
