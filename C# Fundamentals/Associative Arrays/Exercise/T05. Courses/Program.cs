using System;
using System.Collections.Generic;

namespace T05._Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            var list = new Dictionary<string, List<string>>();
            var listCount = new Dictionary<string,int>();
            while(text != "end")
            {
                string[] strings = text.Split(" : ");
                string course = strings[0];
                string name = strings[1];
                if (list.ContainsKey(course))
                {
                    list[course].Add(name);
                    listCount[course]++;
                }
                else
                {
                    list.Add(course, new List<string>());
                    list[course].Add(name);
                    listCount.Add(course, 1);
                }

                text = Console.ReadLine();
            }
            foreach (var item in list)
            {
                foreach (var it in listCount)
                {
                    if (it.Key.Equals(item.Key))
                    {
                        Console.WriteLine($"{item.Key}: {it.Value}");
                        break;
                    }
                    
                }
                foreach (var ite in item.Value)
                {
                    Console.WriteLine($" -- {ite}");
                }
            }
        }
    }
}
