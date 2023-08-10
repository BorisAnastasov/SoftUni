using System;
using System.Collections.Generic;
using System.Linq;

namespace T03._Maximum_and_Minimum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(" ").ToArray();
                switch (command[0])
                {
                    case "1":
                        stack.Push(int.Parse(command[1]));
                        break;
                        case "2":
                        if(stack.Count > 0)
                        {
                            stack.Pop();
                        }                        
                        break;
                    case "3":
                        if(stack.Count> 0)
                        {
                            Console.WriteLine(stack.Max());
                        }                       
                        break;
                    case "4":
                        if (stack.Count > 0)
                        {
                            Console.WriteLine(stack.Min());
                        }
                        break;
                }
            }
            Console.WriteLine(String.Join(", ",stack));
        }
    }
}
