using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace P05_ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            char current = input[0];
            char prev = ' ';

            for (int i = 1; i < input.Length; i++)
            {
                if (current != input[i])
                {
                    prev = current;
                    sb.Append(prev);
                    current = input[i];
                }

                if (i == input.Length - 1 && prev != current)
                {
                    sb.Append(current);
                }
            }


            Console.WriteLine(sb);
        }
    }
}
