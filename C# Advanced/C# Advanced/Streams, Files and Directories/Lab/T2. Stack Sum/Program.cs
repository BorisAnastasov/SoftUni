using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;

namespace T2._Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>(Console.ReadLine().Split(" ").Select(int.Parse).ToList());
            string command = Console.ReadLine().ToLower();
            while(command != "end")
            {
                string[] arr = command.Split(" ").ToArray();
                if (arr[0] == "add")
                {
                    int num1 = int.Parse(arr[1]);
                    int num2 = int.Parse(arr[2]);
                    stack.Push(num1);
                    stack.Push(num2);
                }
                else if (arr[0] == "remove")
                {
                    int num = int.Parse(arr[1]); 
                    if(stack.Count < num)
                    {
                        command = Console.ReadLine().ToLower();
                        continue;
                    }
                    else
                    {
                        for (int i = 0; i < num; i++)
                        {
                            stack.Pop();
                        }
                    }
                    
                }
                command = Console.ReadLine().ToLower();
            }
            int sum = 0;
            foreach (int item in stack)
            {
                sum += item;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
