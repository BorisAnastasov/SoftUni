using System;
using System.Collections.Generic;

namespace T8._Traffic_Jam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            Queue<string> queue = new Queue<string>();
            string text = Console.ReadLine();
            while (text != "end")
            {
                if (text == "green")
                {
                    if(queue.Count >= n)
                    {
                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine($"{queue.Dequeue()} passed!");
                            count++;
                        }
                    }
                    else
                    {
                        for (int i = 0; i < queue.Count; i++)
                        {
                            count++;
                            i--;
                            Console.WriteLine($"{queue.Dequeue()} passed!");
                        }
                    }
                    
                }
                else
                {
                    queue.Enqueue(text);    
                }

                text = Console.ReadLine();
            }
            Console.WriteLine($"{count} cars passed the crossroads.");

        }
    }
}
