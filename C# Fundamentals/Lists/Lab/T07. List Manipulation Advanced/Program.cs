using System;
using System.Collections.Generic;
using System.Linq;

namespace T07._List_Manipulation_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            string command = Console.ReadLine();
            bool cont = false;
            bool ischecked = false;
            while (command != "end")
            {
                string[] arr = command.Split(" ").ToArray();
                switch (arr[0])
                {
                    case "Add":
                        ischecked = true;
                        list.Add(int.Parse(arr[1]));
                        break;
                    case "Remove":
                        ischecked = true;
                        list.Remove(int.Parse(arr[1]));
                        break;
                    case "RemoveAt":
                        ischecked = true;
                        list.RemoveAt(int.Parse(arr[1]));
                        break;
                    case "Insert":
                        ischecked = true;
                        int n = int.Parse(arr[1]);
                        int t = int.Parse(arr[2]);
                        list.Insert(t, n);
                        break;
                    case "Contains":
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i] == int.Parse(arr[1]))
                            {
                                cont = true;
                            }
                        }
                        if (cont)
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        cont = false;
                        break;
                    case "PrintEven":
                        List<int> even = new List<int>();
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i] %2 == 0)
                            {
                                even.Add(list[i]);
                            }
                        }
                        Console.WriteLine(string.Join(" ",even));
                        break;
                    case "PrintOdd":
                        List<int> odd = new List<int>();
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i] % 2 != 0)
                            {
                                odd.Add(list[i]);
                            }
                        }
                        Console.WriteLine(string.Join(" ", odd));
                        break;
                    case "GetSum":
                        int sum = 0;
                        for (int i = 0; i < list.Count; i++)
                        {
                            sum += list[i];
                        }
                        Console.WriteLine(sum);
                        break;                        
                    case "Filter":                                                   
                            switch (arr[1]) 
                            {
                                case "<":
                                    List<int> r = new List<int>();
                                    for (int j = 0; j < list.Count; j++)
                                    {
                                        if(list[j] < int.Parse(arr[2]))
                                        {
                                            r.Add(list[j]);
                                        }
                                    }
                                    Console.WriteLine(string.Join(" ",r));
                                    break;
                                case "<=":
                                    List<int> z = new List<int>();
                                    for (int j = 0; j < list.Count; j++)
                                    {
                                        if (list[j] <= int.Parse(arr[2]))
                                        {
                                            z.Add(list[j]);
                                        }
                                    }
                                    Console.WriteLine(string.Join(" ", z));
                                    break;
                                case ">":
                                    List<int> d = new List<int>();
                                    for (int j = 0; j < list.Count; j++)
                                    {
                                        if (list[j] > int.Parse(arr[2]))
                                        {
                                            d.Add(list[j]);
                                        }
                                    }
                                    Console.WriteLine(string.Join(" ", d));
                                    break;
                                case ">=":
                                    List<int> s = new List<int>();
                                    for (int j = 0; j < list.Count; j++)
                                    {
                                        if (list[j] >= int.Parse(arr[2]))
                                        {
                                            s.Add(list[j]);
                                        }
                                    }
                                    Console.WriteLine(string.Join(" ", s));
                                    break;
                            }                        
                        break;
                }
                command = Console.ReadLine();
            }
            if (ischecked)
            {
                Console.WriteLine(string.Join(" ",list));
            }
            
        }
    }
}
