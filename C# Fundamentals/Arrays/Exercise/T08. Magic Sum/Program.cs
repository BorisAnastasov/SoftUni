using System;
using System.Linq;
namespace T08._Magic_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = i; j < arr.Length-1; j++)
                {
                    if (arr[i] + arr[j + 1] == n)
                    {
                        Console.WriteLine($"{arr[i]} {arr[j + 1]}");
                    }
                }
                
            }
        }
    }
}
