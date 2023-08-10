using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;

namespace T10._Crossroads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int greenLight = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());
            int count = 0;
            Queue<string> queue = new Queue<string>();
            string text = Console.ReadLine();
            while(text != "END")
            {
                if(text == "green")
                {
                    int currGL = greenLight;
                    int currFW = freeWindow;
                    while (queue.Count >0)
                    {
                        string car = queue.Dequeue();
                        int chars = car.Length;
                        if (currGL-chars == 0)
                        {                            
                            count++;
                            break;
                        }
                        else if(currGL - chars < 0)
                        {
                            currGL += currFW;
                            if(currGL-chars >= 0)
                            {
                                count++;
                                break;
                            }
                            else
                            {
                                currGL-=chars;
                                currGL = Math.Abs(currGL);
                                char characterHit = car[car.Length - currGL];
                                Console.WriteLine("A crash happened!");
                                Console.WriteLine($"{car} was hit at {characterHit}.");
                                return;
                            }
                        }
                        else
                        {
                            currGL -= chars;
                            count++;
                        }
                    }
                }
                else
                {
                    queue.Enqueue(text);
                }
                text = Console.ReadLine();
            }
            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{count} total cars passed the crossroads.");
        }
    }
}
