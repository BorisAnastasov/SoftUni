using System;
using System.Collections.Generic;
using System.Linq;
namespace T03._Merging_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers1 = Console.ReadLine().Split(" ").Select(double.Parse).ToList();
            List<double> numbers2 = Console.ReadLine().Split(" ").Select(double.Parse).ToList();
            List<double> numbers3 = new List<double>();
            int i = 0;
            while(numbers3.Count != numbers2.Count + numbers1.Count)
            {
                if (i <= numbers1.Count - 1)
                {
                    numbers3.Add(numbers1[i]);
                }
                if (i <= numbers2.Count - 1)
                {
                    numbers3.Add(numbers2[i]);
                }
                i++;
            }
            Console.WriteLine(string.Join(" ",numbers3));
        }
    }
}
