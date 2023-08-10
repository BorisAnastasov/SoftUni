using System;
using System.Collections.Generic;
using System.Linq;
namespace T01._Sort_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>();   
            foreach (var item in arr.Where(x=>x%2==0).OrderBy(x=>x))
            {
                queue.Enqueue(item);
            }
            Console.WriteLine(String.Join(", ",queue));
        }
    }
}
