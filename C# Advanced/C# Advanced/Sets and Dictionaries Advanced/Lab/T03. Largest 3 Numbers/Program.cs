using System;
using System.Linq;

namespace T03._Largest_3_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).OrderByDescending(n=>n).ToArray();
            if(arr.Length < 3)
            {
                Console.WriteLine(String.Join(" ",arr));
                return;
            }
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }
    }
}
