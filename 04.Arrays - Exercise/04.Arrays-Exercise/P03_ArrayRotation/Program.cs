using System;
using System.Diagnostics;
using System.Linq;
using System.Xml.Serialization;

namespace P03_ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int steps = int.Parse(Console.ReadLine());

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            for (int i = 0; i < steps % array.Length; i++)
            {
                int temp = array[0];

                for (int j = 0; j < array.Length - 1; j++)
                {
                    array[j] = array[j + 1];
                }

                array[array.Length - 1] = temp;
            }
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            Console.WriteLine(ts);
            Console.WriteLine(string.Join(" ", array));



        }
    }
}
