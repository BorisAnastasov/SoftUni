using System;
using System.Collections.Generic;
using System.Linq;

namespace T10._ForceBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> people = new List<string>();
            var list = new Dictionary<string, List<string>>();
            while (input != "Lumpawaroo")
            {
                if (input.Contains("|"))
                {
                    string[] arr = input.Split(" | " ,StringSplitOptions.RemoveEmptyEntries);
                    string side = arr[0];
                    string user = arr[1];
                    if (!list.ContainsKey(side))
                    {
                        list.Add(side, new List<string>());
                    }
                    list[side].Add(user);
                    people.Add(user);
                }
                else if (input.Contains("->"))
                {
                    string[] arr = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                    string user = arr[0];
                    string side = arr[1];
                    if (people.Contains(user))
                    {
                        foreach (var item in list)
                        {
                            if (item.Value.Contains(user))
                            {
                                list[item.Key].Remove(user);
                            }
                        }
                    }
                    if (!list.ContainsKey(side))
                    {
                        list.Add(side, new List<string>());
                    }
                    list[side].Add(user);
                    people.Add(user);
                    Console.WriteLine($"{user} joins the {side} side!");
                }

                input = Console.ReadLine();
            }
            foreach (var item in list.OrderByDescending(x=>x.Value.Count).ThenBy(x=>x.Key))
            {
                if(item.Value.Count > 0)
                {
                    Console.WriteLine($"Side: {item.Key}, Members: {item.Value.Count}");
                    foreach (var i in item.Value.OrderBy(x => x))
                    {
                        Console.WriteLine($"! {i}");
                    }
                }
               
            }
        }
    }
}
