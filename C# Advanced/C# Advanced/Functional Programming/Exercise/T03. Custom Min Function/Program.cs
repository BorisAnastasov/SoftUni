using System;
using System.Linq;

namespace T03._Custom_Min_Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Func<int[], int> func = arr => arr.Min();
            Console.WriteLine(func(arr)); 
        }
    }
}
