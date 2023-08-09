using System;
using System.Numerics;

namespace T03._Exact_Sum_of_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal sum = 0;
            for (int i = 0; i < n; i++)
            {
                 decimal b  = decimal.Parse(Console.ReadLine());
                sum += b;
            }
            Console.WriteLine(sum);
        }
    }
}
