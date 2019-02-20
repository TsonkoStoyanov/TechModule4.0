using System;

namespace P13_LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());


            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            double longestLine = LongestLine(x1, y1, x2, y2, x3, y3, x4, y4);

            if (longestLine == x1)
            {

                ClosestToCenter(x1, y1, x2, y2);
            }
            else
            {
                ClosestToCenter(x3, y3, x4, y4);

            }

        }


        private static void ClosestToCenter(double x1, double y1, double x2, double y2)
        {
            double firstPoint = Math.Abs(x1) + Math.Abs(y1);
            double secondPoint = Math.Abs(x2) + Math.Abs(y2);

            if (secondPoint < firstPoint)
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
        }


        private static double LongestLine(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {

            double firstLength = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));

            double secondLength = Math.Sqrt((x4 - x3) * (x4 - x3) + (y4 - y3) * (y4 - y3));

            if (secondLength > firstLength)
            {
                return x3;
            }
            else
            {
                return x1;
            }
        }

    }
}
