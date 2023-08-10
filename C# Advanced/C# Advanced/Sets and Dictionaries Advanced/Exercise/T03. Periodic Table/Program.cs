using System;
using System.Collections.Generic;
using System.Linq;
namespace T03._Periodic_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SortedSet<string> s = new SortedSet<string>();
            for (int i = 0; i < n; i++)
            {
                string[] arr = Console.ReadLine().Split(" ").ToArray();
                for (int k = 0; k < arr.Length; k++)
                {
                    s.Add(arr[k]);
                }
            }
            foreach (var item in s)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
