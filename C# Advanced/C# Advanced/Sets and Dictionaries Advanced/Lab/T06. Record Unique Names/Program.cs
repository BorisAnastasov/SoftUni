using System;
using System.Collections.Generic;

namespace T06._Record_Unique_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var set = new HashSet<string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                set.Add(name);
            }

            foreach (var item in set)
            {
                Console.WriteLine(item);
            }
        }
    }
}
