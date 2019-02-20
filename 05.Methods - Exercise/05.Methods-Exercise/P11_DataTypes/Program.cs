using System;

namespace P11_DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            string type = Console.ReadLine();
            string input = Console.ReadLine();


            if (type == "int")
            {
                PrintResult(int.Parse(input));
            }
            else if (type == "real")
            {
                PrintResult(double.Parse(input));

            }
            else if (type == "string")
            {
                PrintResult(input);

            }
        }

        private static void PrintResult(string input)
        {
            Console.WriteLine($"${input}$");
        }

        private static void PrintResult(double number)
        {
            Console.WriteLine($"{number * 1.5:f2}");
        }

        private static void PrintResult(int number)
        {
            Console.WriteLine(number * 2);
        }
    }
}
