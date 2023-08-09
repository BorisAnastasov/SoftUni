using System;
using System.Collections.Generic;
using System.Linq;


namespace T04._List_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            string command = Console.ReadLine();
            int curr = 0;
            while (command != "End")
            {
                string[] arr = command.Split(" ").ToArray();
                switch (arr[0])
                {
                    case "Add":
                        list.Add(int.Parse(arr[1]));
                        break;
                    case "Insert":
                        if(list.Count-1 >= int.Parse(arr[2])&& int.Parse(arr[2])>=0)
                        {
                            list.Insert(int.Parse(arr[2]), int.Parse(arr[1]));
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;
                    case "Remove":                        
                        if (list.Count-1 >= int.Parse(arr[1]) && int.Parse(arr[1]) >= 0)
                        {
                            list.RemoveAt(int.Parse(arr[1]));
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;
                }
                if (arr[1] == "right")
                {
                    for (int i = 0; i < int.Parse(arr[2]); i++)
                    {
                        if(list[list.Count - 1] != 0)
                        {
                            curr = list[list.Count - 1];
                            for (int j = list.Count - 1; j > 0; j--)
                            {
                                list[j] = list[j - 1];
                            }
                            list[0] = curr;
                            curr = 0;
                        }                        
                        
                    }
                }
                else if (arr[1] == "left")
                {
                    for (int i = 0; i < int.Parse(arr[2]); i++)
                    {
                        if(list[0] != 0)
                        {
                            curr = list[0];
                            for (int j = 0; j < list.Count - 1; j++)
                            {
                                list[j] = list[j + 1];
                            }
                            list[list.Count - 1] = curr;
                            curr = 0;
                        }                       
                        
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",list));
        }
        
    }
}
