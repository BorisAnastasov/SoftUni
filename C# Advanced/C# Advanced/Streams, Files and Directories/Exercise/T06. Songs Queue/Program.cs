using System;
using System.Collections.Generic;
using System.Linq;

namespace T06._Songs_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>(Console.ReadLine().Split(", ").ToList());
            string command = Console.ReadLine();
            while (command != null)
            {
                if (command.Contains("Play"))
                {                     
                    queue.Dequeue();
                    if (queue.Count == 0)
                    {
                        Console.WriteLine("No more songs!");
                        return;
                    }


                }
                else if (command.Contains("Add"))
                {

                    string song = command.Substring(4,command.Length-4);
                    if (queue.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                    else
                    {
                        queue.Enqueue(song);
                    }
                }
                else if (command.Contains("Show"))
                {
                    Console.WriteLine(String.Join(", ",queue));
                }

                command = Console.ReadLine();
            }
            
        }
    }
}
