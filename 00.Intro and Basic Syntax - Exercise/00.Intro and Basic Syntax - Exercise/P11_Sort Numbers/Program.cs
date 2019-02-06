using System;

namespace P11_Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());

            bool isFirst = false;
            bool isSecond = false;
            bool isThird = false;

            if (number1 >= number2 && number1 >= number3)
            {
                Console.WriteLine(number1);
                isFirst = true;
            }
            else if (number2 >= number1 && number2 >= number3)
            {
                Console.WriteLine(number2);
                isSecond = true;
            }

            else if (number3 >= number1 && number3 >= number2)
            {
                Console.WriteLine(number3);
                isThird = true;
            }

            if (isThird)
            {
                if (number1 >= number2)
                {
                    Console.WriteLine(number1);
                    Console.WriteLine(number2);
                }
                else
                {
                    Console.WriteLine(number2);
                    Console.WriteLine(number1);
                }
            }
            else if (isSecond)
            {
                if (number1 >= number3)
                {
                    Console.WriteLine(number1);
                    Console.WriteLine(number3);
                }
                else
                {
                    Console.WriteLine(number3);
                    Console.WriteLine(number1);
                }
            }
            else
            {
                if (number2 >= number3)
                {
                    Console.WriteLine(number2);
                    Console.WriteLine(number3);
                }
                else
                {
                    Console.WriteLine(number3);
                    Console.WriteLine(number2);
                }
            }
        }
    }
}

