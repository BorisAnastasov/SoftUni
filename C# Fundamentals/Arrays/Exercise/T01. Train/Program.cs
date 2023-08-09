using System;

namespace T01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                arr[i] = num;
                sum += num;
            }
            Console.WriteLine(String.Join(' ',arr));
            Console.WriteLine(sum);
        }
    }
}
