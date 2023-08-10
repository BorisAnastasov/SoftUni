using System;
using System.Collections.Generic;
using System.Linq;

namespace T5._Print_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    queue.Enqueue(arr[i]);
                }
                
            }
            Console.WriteLine(String.Join(", ",queue));
        }
    }
}
