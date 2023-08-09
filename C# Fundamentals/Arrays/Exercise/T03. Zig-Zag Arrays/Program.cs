using System;
using System.Linq;
namespace T03._Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr1 = new int[n];
            int[] arr2 = new int[n];
            int count = 1;
            for (int i = 0; i < n; i++)
            {
                int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                if (count%2 ==0)
                {
                    arr1[i] = arr[1];
                    arr2[i] = arr[0];
                }
                else
                {
                    arr1[i] = arr[0];
                    arr2[i] = arr[1];
                }
                count++;
            }
            Console.WriteLine(string.Join(' ',arr1));
            Console.WriteLine(string.Join(' ', arr2));
        }
    }
}
