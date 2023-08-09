using System;
using System.Collections.Generic;

namespace _01._Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ");
            List<string> validUsernames =new List<string>();
            List<string> results = new List<string>();
            foreach (var item in usernames)
            {
                if(item.Length>=3&& item.Length<=16)
                {
                    validUsernames.Add(item);
                    results.Add(item);
                }
            }
            
            foreach (var item in validUsernames)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    char sym = item[i];
                    if (!(char.IsLetter(sym) || char.IsDigit(sym) || sym == '_' || sym == '-'))
                    {
                        results.Remove(item);
                        break;
                    }
                }
            }
            foreach (var item in results)
            {
                Console.WriteLine(item);
            }
        }
    }
}
