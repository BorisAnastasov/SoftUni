using System;
using System.Collections.Generic;
using System.Linq;

namespace T01._Count_Same_Values_in_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] arr = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();
            var dictionary = new Dictionary<double,int>();
            foreach (double item in arr)
            {
                if (dictionary.ContainsKey(item))
                {
                    dictionary[item]++;
                }
                else
                {
                    dictionary[item] = 1;
                }
            }
            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
