using System;
using System.Collections.Generic;
using System.Linq;
namespace T02._Change_List
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
                if (arr[0] == "Delete")
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] == int.Parse(arr[1]))                            
                        {
                            list.RemoveAt(i);
                        }
                    }
                }
                else
                {
                    int num = int.Parse(arr[1]);
                    int index = int.Parse(arr[2]);
                    list.Insert(index, num);
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",list));
        }
    }
}
