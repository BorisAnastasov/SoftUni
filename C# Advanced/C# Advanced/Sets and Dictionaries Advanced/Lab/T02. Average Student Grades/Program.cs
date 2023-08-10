using System;
using System.Collections.Generic;
using System.Linq;

namespace T02._Average_Student_Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var dictionary = new Dictionary<string, List<decimal>>();
            for (int i = 0; i < n; i++)
            {
                string[] arr = Console.ReadLine().Split(" ").ToArray();
                string name = arr[0];
                decimal grade = decimal.Parse(arr[1]);
                if (dictionary.ContainsKey(name))
                {
                    dictionary[name].Add(grade);
                }
                else
                {
                    dictionary[name] = new List<decimal>();
                    dictionary[name].Add(grade);
                }
            }
            foreach (var item in dictionary)
            {
                Console.Write($"{item.Key} -> ");
                foreach (var part in item.Value)
                {
                    Console.Write($"{part:f2} ");
                }
                Console.WriteLine($"(avg: {item.Value.Average():f2})");
            }
            
        }
    }
}
