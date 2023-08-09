using System;
using System.Collections.Generic;

namespace T07._Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            var list = new Dictionary<string, List<string>>();
            while(text != "End")
            {
                string[] data = text.Split(" -> ");
                string company = data[0];
                string id = data[1];
                if (list.ContainsKey(company))
                {
                    if (!list[company].Contains(id))
                    {
                        list[company].Add(id);
                    }                    
                }
                else
                {
                    list.Add(company, new List<string>());
                    list[company].Add(id);
                }
                text = Console.ReadLine();
            }
            foreach (var item in list)
            {
                Console.WriteLine(item.Key);
                foreach (var it in item.Value)
                {
                    Console.WriteLine($" -- {it}");
                }
            }
        }
    }
}
