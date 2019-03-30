using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace P01_ActivationKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split("&");

            string pattern = @"[A-Za-z0-9]{16,25}";

            List<string> resultKey = new List<string>();

            foreach (var input in inputs)
            {
                if (Regex.IsMatch(input, pattern))
                {
                    string result = ModifyInput(input);
                    resultKey.Add(result);
                }
            }

            Console.WriteLine(string.Join(", ", resultKey));
        }

        private static string ModifyInput(string input)
        {
            StringBuilder sb = new StringBuilder();

            if (input.Length == 16)
            {
                int count = 4;

                for (int i = 0; i <= input.Length - 1; i++)
                {
                    if (count == 0)
                    {
                        sb.Append("-");
                        count = 4;
                    }

                    if (char.IsDigit(input[i]))
                    {
                        int digit = input[i] - 48;

                        sb.Append(9 - digit);
                    }
                    else
                    {
                        sb.Append(char.ToUpper(input[i]));
                    }

                    count--;
                }
            }
            else if (input.Length == 25)
            {
                int count = 5;
                for (int i = 0; i <= input.Length - 1; i++)
                {
                    if (count == 0)
                    {
                        sb.Append("-");
                        count = 5;
                    }

                    if (char.IsDigit(input[i]))
                    {
                        int digit = input[i] - 48;

                        sb.Append(9 - digit);
                    }
                    else
                    {
                        sb.Append(char.ToUpper(input[i]));
                    }
                    count--;
                }
            }


            return sb.ToString();
        }
    }
}
