using System;
using System.Linq;
namespace Т07._Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int count = 1;
            int maxCount = 1;
            int curr = 0;
            int maxCurr = 0;
            for (int i = 0; i < arr.Length-1; i++)
            {
                if(arr[i] == arr[i + 1])
                {
                    count++;
                    curr = arr[i];
                }
                else
                {
                    curr = 0;
                    count = 1;
                }
                if (count > maxCount)
                {
                    maxCount = count;
                    maxCurr = curr;
                }

            }
            for (int i = 0; i < maxCount; i++)
            {
                Console.Write($"{maxCurr} ");
            }

        }
    }
}
