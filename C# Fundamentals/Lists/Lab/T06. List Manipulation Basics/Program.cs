using System;
using System.Collections.Generic;
using System.Linq;
namespace T06._List_Manipulation_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            string command = Console.ReadLine();
            while(command != "end")
            {
                string[] arr = command.Split(" ").ToArray();
                switch (arr[0]) 
                {
                    case "Add":
                        list.Add(int.Parse(arr[1]));
                        break;
                    case "Remove":
                        list.Remove(int.Parse(arr[1]));
                        break;
                    case "RemoveAt":
                        list.RemoveAt(int.Parse(arr[1]));
                        break;
                    case "Insert":
                        int n = int.Parse(arr[1]);
                        int t = int.Parse(arr[2]);
                        list.Insert(t,n);
                        break;
                }
                command = Console.ReadLine();   
            }
            Console.WriteLine(String.Join(" ",list));
        }
    }
}
