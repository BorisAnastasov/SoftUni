using System;
using System.Collections.Generic;
using System.Linq;

namespace T07._Predicate_For_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split(" ").ToArray();
            Func<string[],int, List<string>> func = (names,n) =>
            {
                List<string> list = new List<string>();
                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i].Length<=n)
                    {
                        list.Add(names[i]);
                    }
                }
                return list;
            };
            List<string> list = func(names, n);
            Console.WriteLine(string.Join(Environment.NewLine,list));
        }
    }
}
