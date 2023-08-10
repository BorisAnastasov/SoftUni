using System;
using System.Linq;

namespace T04._Add_VAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine().Split(", ").Select(double.Parse).Select(n=>n*1.2).ToArray();
            foreach (var item in input)
            {
                Console.WriteLine($"{item:f2}");
            }
        }
    }
}
