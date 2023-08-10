using System;
using System.Collections.Generic;
using System.Linq;

namespace T04._Fast_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            Queue<int> queue = new Queue<int>(Console.ReadLine().Split(" ").Select(int.Parse).ToList());            
            Console.WriteLine(queue.Max());
            for (int i = 0; i < queue.Count; i++)
            {
                if (queue.Peek() <= m)
                {
                    m -= queue.Peek();
                    queue.Dequeue();
                    i--;
                }
                else
                {
                    Console.WriteLine($"Orders left: {String.Join(" ", queue)}");
                    return;
                }
            }
            Console.WriteLine("Orders complete");
        }
    }
}
