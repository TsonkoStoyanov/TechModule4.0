using System;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
using System.Text;

namespace P04_MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().TrimStart('0');

            int digitToMultiply = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();

            int residue = 0;

            if (string.IsNullOrWhiteSpace(input) || digitToMultiply == 0)
            {
                Console.WriteLine(0);
                return;
            }


            for (int i = input.Length - 1; i >= 0; i--)
            {
                int currentDigit = input[i] - 48;

                int result = currentDigit * digitToMultiply + residue;

                if (result > 9)
                {
                    sb.Append(result % 10);
                    residue = result / 10;
                }
                else
                {
                    sb.Append(result);
                    residue = 0;
                }
            }

            if (residue > 0)
            {
                sb.Append(residue);
            }

            var newResult = sb.ToString().Reverse().ToArray();

            Console.WriteLine(newResult);

        }
    }
}
