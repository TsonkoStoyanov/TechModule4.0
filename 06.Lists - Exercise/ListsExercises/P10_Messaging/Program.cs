using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P10_Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string message = Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            int count = 0;

            foreach (var number in numbers)
            {
                int index = GetSum(number);

                while (index > message.Length)
                {
                    index -= message.Length;
                }

                Console.Write(message[index + count]);
                count++;
            }

            Console.WriteLine();
        }

        private static int GetSum(int number)
        {
            int result = 0;

            while (number > 0)
            {
                result += number % 10;
                number /= 10;
            }


            return result;

        }
    }
}
