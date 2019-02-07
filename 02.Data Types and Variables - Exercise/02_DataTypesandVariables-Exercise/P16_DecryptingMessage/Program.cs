using System;

namespace P16_DecryptingMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int keyForDecript = int.Parse(Console.ReadLine());

            int numberOfLines = int.Parse(Console.ReadLine());

            string result = string.Empty;

            for (int i = 0; i < numberOfLines; i++)
            {
                char curChar = char.Parse(Console.ReadLine());

                result += (char)(curChar+keyForDecript);
            }

            Console.WriteLine(result);
        }
    }
}
