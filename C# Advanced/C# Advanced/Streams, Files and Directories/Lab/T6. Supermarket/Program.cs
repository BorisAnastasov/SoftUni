using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace T6._Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            string text = Console.ReadLine();
            while(text != "End")
            {
                if(text == "Paid")
                {
                    foreach (var item in queue)
                    {
                        Console.WriteLine(item);
                    }
                    queue.Clear();
                }
                else
                {
                    queue.Enqueue(text);
                }

                text = Console.ReadLine();
            }
            int count = queue.Count;
            Console.WriteLine($"{count} people remaining.");
        }
    }
}
