using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P09_RageQuit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            StringBuilder temp = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    string number = input[i].ToString();

                    if (i + 1 < input.Length)
                    {
                        if (char.IsDigit(input[i + 1]))
                        {
                            i++;
                            number += input[i].ToString();
                        }
                    }

                    int numberOfRepeat = int.Parse(number);

                    for (int j = 0; j < numberOfRepeat; j++)
                    {
                        sb.Append(temp);
                    }

                    temp.Clear();
                }
                else
                {
                    char symbol = char.ToUpper(input[i]);

                    temp.Append(symbol);
                }
            }

            var count = sb.ToString().Distinct().Count();

            Console.WriteLine($"Unique symbols used: {count}");
            Console.WriteLine(sb);
        }
    }
}
