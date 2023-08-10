using System;
using System.Collections.Generic;
using System.Linq;

namespace T08._List_Of_Predicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                list.Add(i);
            }
            List<int> dividers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            Func<int, List<int>, List<int>> func = (n, list) =>
            {
                List<int> result = list;
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] % n != 0)
                    {
                        result.Remove(list[i]);
                        i--;
                    }
                }
                return result;
            };
            for (int i = 0; i < dividers.Count; i++)
            {
                list = func(dividers[i], list);
            }
            Console.WriteLine(String.Join(" ",list));
        }

    }
}
