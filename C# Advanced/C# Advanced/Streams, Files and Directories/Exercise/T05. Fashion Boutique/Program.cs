using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;

namespace T05._Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>(Console.ReadLine().Split(" ").Select(int.Parse).ToList());
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            int sum = 0;
            for (int i = 0; i < stack.Count; i++)
            {
                
                if (sum + stack.Peek() > n)
                {
                    sum = 0;
                    count++;
                    i--;
                }
                else if (sum + stack.Peek() == n)
                {
                    stack.Pop();
                    i--;
                    sum = 0;
                    count++;
                }
                else
                {
                    sum += stack.Pop();
                    i--;
                }
            }
            if (sum > 0)
            {
                count++;
            }
            Console.WriteLine(count);
        }
    }
}
