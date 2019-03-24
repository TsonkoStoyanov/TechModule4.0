using System;
using System.Text;

namespace P03_CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            string input = Console.ReadLine();


            for (int i = 0; i < input.Length; i++)
            {
                sb.Append((char)(input[i] + 3));

            }

            Console.WriteLine(sb);
        }
    }
}
