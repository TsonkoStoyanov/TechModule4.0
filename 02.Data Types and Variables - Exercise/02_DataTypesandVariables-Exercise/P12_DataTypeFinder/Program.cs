using System;
using System.Reflection;

namespace DataTypeFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                if (Boolean.TryParse(input, out bool result))
                {
                    Console.WriteLine($"{input} is boolean type");
                }
                else if (long.TryParse(input, out long intResult))
                {
                    Console.WriteLine($"{input} is integer type");
                }
                else if (char.TryParse(input, out char charResult))
                {
                    Console.WriteLine($"{input} is character type");
                }
                else if (double.TryParse(input, out double floatResult))
                {
                    Console.WriteLine($"{input} is floating point type");
                }
                else
                {
                    Console.WriteLine($"{input} is string type");
                }
                
                input = Console.ReadLine();
            }
        }
    }
}