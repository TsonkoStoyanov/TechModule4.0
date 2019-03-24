using System;
using System.Text;

namespace P06_StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '>')
                {
                    sb.Append('>');
                    int power = input[i + 1] - 48;

                    int startIndex = i + 1;

                    for (int j = startIndex; j < startIndex + power && j < input.Length - 1; j++)
                    {
                        if (input[j] == '>')
                        {
                            sb.Append('>');
                            i++;
                            power += input[j + 1] - 48;
                        }

                        i++;
                    }

                }
                else
                {
                    sb.Append(input[i]);
                }


            }

            Console.WriteLine(sb);
        }
    }
}
