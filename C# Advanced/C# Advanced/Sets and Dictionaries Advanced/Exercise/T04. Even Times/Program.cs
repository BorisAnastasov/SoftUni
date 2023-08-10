using System;
using System.Collections.Generic;

namespace T04._Even_Times
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var dict = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (!dict.ContainsKey(num))
                {
                    dict.Add(num, 1);
                }
                else
                {
                    dict[num]++;

                }
            }
            foreach (var item in dict)
            {
                if(item.Value %2 == 0)
                {
                    Console.WriteLine(item.Key);
                    return;
                }
            }
        }
    }
}
