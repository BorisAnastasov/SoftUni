using System;
using System.Collections.Generic;
using System.Linq;

namespace T05._Cities_by_Continent_and_Country
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var dictionary = new Dictionary<string, Dictionary<string, List<string>>>();
            for (int i = 0; i < n; i++)
            {
                string[] arr = Console.ReadLine().Split(" ").ToArray();
                string continent = arr[0];
                string country = arr[1];
                string city = arr[2];
                if (dictionary.ContainsKey(continent))
                {
                    if (dictionary[continent].ContainsKey(country))
                    {
                        dictionary[continent][country].Add(city);
                    }
                    else
                    {
                        dictionary[continent].Add(country, new List<string>());
                        dictionary[continent][country].Add(city);
                    }
                }
                else
                {
                    dictionary[continent] = new Dictionary<string, List<string>>();
                    dictionary[continent].Add(country, new List<string>());
                    dictionary[continent][country].Add(city);
                }
            }
            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key}:");
                foreach (var i in item.Value)
                {
                    Console.Write($"  {i.Key} -> ");
                    Console.Write(String.Join(", ",i.Value));
                    Console.WriteLine();
                }
            }
        }
    }
}
