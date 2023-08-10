using System;
using System.Linq;

namespace T02._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int sum = CalculatingTheSum(arr);
            int count = arr.Length;
            Console.WriteLine(count);
            Console.WriteLine(sum);
        }
        static int CalculatingTheSum(int[] arr)
        {
            int sum = 0;    
            foreach (var item in arr)
            {
                sum += item;
            }
            return sum;
        }
    }
}
