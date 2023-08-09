using System;
using System.Collections.Generic;

namespace T03._Word_Synonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var words = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string syn = Console.ReadLine();
                if (words.ContainsKey(word))
                {                   
                    words[word].Add(syn);
                }
                else
                {
                    words.Add(word, new List<string>());
                    words[word].Add(syn);
                }
            }
            foreach (var item in words)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ",item.Value)}");
            }
        }
    }
}
