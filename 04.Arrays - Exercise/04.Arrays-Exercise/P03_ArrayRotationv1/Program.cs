// C# program for array rotation 
using System;
using System.Diagnostics;
using System.Linq;

class GFG
{
    static void leftRotate(int[] arr, int steps,
        int sizeOfArr)
    {
        int i, j, k, temp;

        int l = GreaterCommonDivizor(steps, sizeOfArr);

        for (i = 0; i < l;  i++)
        {
            temp = arr[i];

            j = i;

            while (true)
            {
                k = j + steps;

                if (k >= sizeOfArr)
                {
                    k = k - sizeOfArr;

                }

                if (k == i)
                {
                    break;
                }
                arr[j] = arr[k];
                j = k;
            }
            arr[j] = temp;
        }
    }

    static void printArray(int[] arr)
    {
        Console.WriteLine(string.Join(" ", arr));
    }

    static int GreaterCommonDivizor(int steps, int sizeOfArr)
    {
        if (sizeOfArr == 0)
        {
            return steps;
        }
        else
        {
            return GreaterCommonDivizor(sizeOfArr, steps % sizeOfArr);
        }
    }


    public static void Main()
    {
        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int steps = int.Parse(Console.ReadLine());
        Stopwatch stopWatch = new Stopwatch();
        stopWatch.Start();
        int realSteps = steps % arr.Length;
        if (realSteps == 0)
        {
            printArray(arr);
            Environment.Exit(0);
        }

        leftRotate(arr, realSteps, arr.Length);

        stopWatch.Stop();
         TimeSpan ts = stopWatch.Elapsed;
            Console.WriteLine(ts);
        printArray(arr);
    }
}



