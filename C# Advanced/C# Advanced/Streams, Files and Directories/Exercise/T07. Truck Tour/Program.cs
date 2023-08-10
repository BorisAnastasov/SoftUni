using System;
using System.Collections.Generic;
using System.Linq;

namespace T07._Truck_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<int> queue = new Queue<int>();
            //calculating the difference
            for (int i = 0; i < n; i++)
            {
                int[] arr = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int amount = arr[0];
                int dist = arr[1];
                int diff = amount - dist;
                queue.Enqueue(diff);
            }
            int index = 0;
            // calculating the best solution
            while (true)
            {
                int sum = 0;
                foreach (int item in queue)
                {
                    sum += item;
                    if (sum < 0)
                    {
                        queue.Enqueue(queue.Dequeue());
                        index++;
                        break;
                    }
                }
                if(sum>= 0)
                {
                    break;
                }
            }
            Console.WriteLine(index);
        }
    }
}
