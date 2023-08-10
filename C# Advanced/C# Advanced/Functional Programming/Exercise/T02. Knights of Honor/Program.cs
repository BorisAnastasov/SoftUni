using System;
using System.Linq;

namespace T02._Knights_of_Honor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<string[]> append =  strings =>
            {
                foreach (var item in strings)
                {
                    Console.WriteLine($"Sir {item}");
                }
            };
            string[] arr = Console.ReadLine().Split(" ").ToArray();
            append(arr);
        }
    }
}
