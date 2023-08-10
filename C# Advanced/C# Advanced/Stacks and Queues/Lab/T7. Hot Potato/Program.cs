using System;
using System.Collections.Generic;
using System.Linq;

namespace T7._Hot_Potato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>(Console.ReadLine().Split(" ").ToList());
            int count = queue.Count;
            int n = int.Parse(Console.ReadLine());
            while(queue.Count > 1)
            {
                for (int i = 1; i <= n; i++)
                {
                    if (i == n)
                    {
                        Console.WriteLine($"Removed {queue.Dequeue()}");
                    }
                    else 
                    {

                        queue.Enqueue(queue.Dequeue());
                    }
                }
            }
            Console.WriteLine($"Last is {queue.Peek()}");
        }
    }
}
