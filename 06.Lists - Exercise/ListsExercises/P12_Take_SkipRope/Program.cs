using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P12_Take_SkipRope
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<char> characters = new List<char>();

            List<int> digits = new List<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    int digit = int.Parse(input[i].ToString());
                    digits.Add(digit);
                }
                else
                {
                    characters.Add(input[i]);
                }
            }

            List<int> takeList = new List<int>();

            List<int> skipList = new List<int>();

            for (int i = 0; i < digits.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(digits[i]);
                }
                else
                {
                    skipList.Add(digits[i]);
                }
            }

            StringBuilder sb = new StringBuilder();

            int take = 0;
            int skip = 0;

            for (int i = 0; i < takeList.Count; i++)
            {

                take = takeList[i];

                var result = characters.Skip(skip).Take(take).ToArray();

                sb.Append(result);

                skip += skipList[i] + take;
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
