using System;
using System.Collections.Generic;
using System.Linq;

namespace T06._Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var list = new Dictionary<string, List<double>>();
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if (!list.ContainsKey(name))
                {
                    list.Add(name, new List<double>());
                    list[name].Add(grade);
                }
                else
                {
                    list[name].Add(grade);
                }
            }
            foreach (var item in list)
            {
                int count = item.Value.Count;
                double sum = item.Value.Sum();
                double aver = sum / count;
                if(aver >= 4.50)
                {
                    Console.WriteLine($"{item.Key} -> {aver:f2}");
                }
                list[item.Key].Clear();
                list[item.Key].Add(aver);
            }

        }
    }
}
