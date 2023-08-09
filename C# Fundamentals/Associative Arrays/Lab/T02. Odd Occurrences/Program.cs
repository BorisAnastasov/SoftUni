using System;
using System.Collections.Generic;
using System.Linq;

namespace T02._Odd_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(" ").ToArray();
            var counts = new Dictionary<string, int>();
            foreach (string word in arr)
            {
                string wordLower = word.ToLower();
                if (counts.ContainsKey(wordLower))
                {
                    counts[wordLower]++;
                }
                else
                {
                    counts.Add(wordLower, 1);
                }
            }
            foreach (var item in counts)
            {
                if(item.Value%2 != 0)
                {
                    Console.Write($"{item.Key} ");
                }
            }
        }
    }
}
