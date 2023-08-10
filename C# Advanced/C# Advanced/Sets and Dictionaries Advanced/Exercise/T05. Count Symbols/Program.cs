using System;
using System.Collections.Generic;

namespace T05._Count_Symbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var d = new SortedDictionary<char, int>();
            char[] arr = Console.ReadLine().ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (!d.ContainsKey(arr[i]))
                {
                    d.Add(arr[i], 1);
                }
                else
                {
                    d[arr[i]]++;
                }
            }
            foreach (var item in d)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
