using System;
using System.Collections.Generic;
using System.Linq;
namespace T03._House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            int n = int.Parse(Console.ReadLine());
            bool th = true;
            bool dr = false;
            for (int i = 0; i < n; i++)
            {
                string[] arr = Console.ReadLine().Split(" ").ToArray();
                if (arr[2] != "not")
                {
                    for (int j = 0; j < list.Count; j++)
                    {
                        if (list[j] == arr[0])
                        {
                            th = false;
                        }
                    }
                    if (th)
                    {
                        list.Add(arr[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{arr[0]} is already in the list!");
                    }
                    th = true;
                }
                else
                {
                    for (int j = 0; j < list.Count; j++)
                    {
                        if (list[j] == arr[0])
                        {
                            dr = true;
                        }
                    }
                    if (dr)
                    {
                        list.Remove(arr[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{arr[0]} is not in the list!");
                    }
                    dr = false;
                }
            }
            foreach (string s in list)
            {
                Console.WriteLine(s);
            }
        }
    }
}
