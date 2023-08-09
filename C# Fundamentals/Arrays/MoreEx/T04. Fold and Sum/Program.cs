using System;
using System.Linq;

namespace T04._Fold_and_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            //calculating left and right side
            int parts = arr.Length/4;
            //left side
            int[] left = new int[parts];
            for (int i = 0; i < left.Length; i++)
            {
                left[i] = arr[i];
            }
            left = left.Reverse().ToArray();
            //right side
            int[] right = new int[parts];
            for (int i = arr.Length-1; i >= 3 * parts; i--)
            {
                right[i- 3 * parts] = arr[i];
            }
            right = right.Reverse().ToArray();
            // sum of right and left
            int[] firstRow = new int[2*parts];
            for (int i = 0; i < parts; i++)
            {
                firstRow[i] = left[i];
            }
            for (int i = parts; i < firstRow.Length; i++)
            {
                firstRow[i] = right[i-parts];
            }
            //calculating middle array
            int[] secondRow = new int[2*parts];
            for (int i = parts; i < 3*parts; i++)
            {
                secondRow[i - parts] = arr[i];
            }
            // calculating the sum
            int[] sum = new int[2*parts];
            for (int i = 0; i < 2*parts; i++)
            {
                sum[i] = firstRow[i] + secondRow[i];
            }
            Console.WriteLine(String.Join(" ",sum));
        }
    }
}
