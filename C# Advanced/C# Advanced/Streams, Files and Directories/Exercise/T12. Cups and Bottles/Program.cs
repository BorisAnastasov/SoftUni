using System;
using System.Collections.Generic;
using System.Linq;

namespace T12._Cups_and_Bottles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> cups = new Queue<int>(Console.ReadLine().Split(" ").Select(int.Parse).ToArray());
            Stack<int> bottles = new Stack<int>(Console.ReadLine().Split(" ").Select(int.Parse).ToArray());
            int wasted = 0;
            int sum = 0;
            while(cups.Count > 0)
            {
                if(cups.Peek() > bottles.Peek()+sum)
                {
                    sum+=bottles.Pop();
                }
                else if (cups.Peek() == bottles.Peek()+sum)
                {
                    bottles.Pop();
                    cups.Dequeue();
                    sum = 0;
                }
                else//<
                {
                    wasted += bottles.Pop()+sum - cups.Dequeue();
                    sum = 0;
                }
                if(bottles.Count == 0)
                {
                    Console.WriteLine($"Cups: {string.Join(" ",cups)}");
                    Console.WriteLine($"Wasted litters of water: {wasted}");
                    return;
                }


            }
            Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");
            Console.WriteLine($"Wasted litters of water: {wasted}");
        }
    }
}
