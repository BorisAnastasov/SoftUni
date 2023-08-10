using System;
using System.Collections.Generic;
using System.Linq;

namespace T02._Sets_of_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> set1 = new HashSet<int>();
            HashSet<int> set2 = new HashSet<int>();
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = arr[0];
            int m = arr[1];
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                set1.Add(num);
            }
            for (int i = 0; i < m; i++)
            {
                int num = int.Parse(Console.ReadLine());
                set2.Add(num);
            }
            HashSet<int> list = new HashSet<int>();
            foreach (var i in set1)
            {
                foreach (var k in set2)
                {
                    if(i == k)
                    {
                        list.Add(i);
                    }
                }
            }
            foreach (var item in list)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
