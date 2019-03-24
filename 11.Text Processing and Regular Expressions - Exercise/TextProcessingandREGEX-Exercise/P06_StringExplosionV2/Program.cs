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

            int strength = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '>')
                {
                    sb.Append('>');

                    strength = input[i + 1] - 48;

                    while (strength > 0 && i < input.Length - 1)
                    {
                        i++;
                        if (input[i] == '>')
                        {
                            sb.Append('>');
                            strength += input[i + 1] - 48;
                            i++;
                        }

                        
                        strength--;
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
