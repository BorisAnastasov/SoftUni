using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace T01._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ");
            var chars = new Dictionary<char, int>();
            foreach (var word in words)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    char sym = word[i];
                    if (chars.ContainsKey(sym))
                    {
                        chars[sym]++;
                    }
                    else
                    {
                        chars.Add(sym, 1);
                    }
                }
            }
            foreach (var item in chars)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
