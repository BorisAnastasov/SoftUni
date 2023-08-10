using System;
using System.Collections.Generic;
using System.Linq;

namespace T06._Reverse_And_Exclude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 2 3 4 5 6
            //2
            List<int> list = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            List<int> result = new List<int>();
            int n = int.Parse(Console.ReadLine());
            Predicate<int> predicate = x => x%n== 0;

            foreach (int item in list)
            {
                if (!predicate(item))
                {
                    result.Add(item);
                }
            }
            for (int i = result.Count - 1; i >= 0; i--)
            {
                Console.Write($"{result[i]} ");
            }
        }
    }
}
