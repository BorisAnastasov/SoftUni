using System;
using System.Collections.Generic;

namespace T04._SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var list = new Dictionary<string, string>();
            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split(" ");
                if (data[0] == "register")
                {
                    if (list.ContainsKey(data[1]))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {data[2]}");
                    }
                    else
                    {
                        list.Add(data[1], data[2]);
                        Console.WriteLine($"{data[1]} registered {data[2]} successfully");
                    }
                }
                else//unregister
                {
                    if (list.ContainsKey(data[1]))
                    {
                        list.Remove(data[1]);
                        Console.WriteLine($"{data[1]} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {data[1]} not found");
                    }
                }
                
            }
            foreach (var item in list)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
