using System;
using System.Linq;

namespace P15_Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfInput = int.Parse(Console.ReadLine());

            string message = string.Empty;

            for (int i = 0; i < numberOfInput; i++)
            {
                
                string number = Console.ReadLine();

                int count = number.Length;

                string first = number.First().ToString();

                int firstNumber = int.Parse(first);

                if (firstNumber == 0)
                {
                    message += " ";
                    continue;
                }
                var offset = Math.Abs((firstNumber - 2) * 3);

                if (firstNumber == 9 || firstNumber == 8)
                {
                    offset++;
                }

                int result = 97 + (offset + count - 1);

                message += (char) result;
            }

            Console.WriteLine(message);
        }
    }
}
