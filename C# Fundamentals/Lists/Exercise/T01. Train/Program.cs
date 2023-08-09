using System;
using System.Collections.Generic;
using System.Linq;

namespace T01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            int n = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            while(command != "end")
            {
                string[] arr = command.Split(' ').ToArray();
                if (arr[0] == "Add")
                {
                    list.Add(int.Parse(arr[1]));
                }
                else
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (n-list[i] >= int.Parse(arr[0]))
                        {
                            list[i] += int.Parse(arr[0]);
                            break;
                        }
                    }
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",list));
        }
    }
}
