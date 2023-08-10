using System;
using System.Collections.Generic;
using System.Linq;

namespace T11._Key_Revolver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int price = 0;
            int barrel = int.Parse(Console.ReadLine());
            int count = barrel;
            Stack<int> bullets = new Stack<int>(Console.ReadLine().Split(" ").Select(int.Parse).ToArray());
            Queue<int> locks = new Queue<int>(Console.ReadLine().Split(" ").Select(int.Parse).ToArray());
            int intelligence = int.Parse(Console.ReadLine());
            while(locks.Count > 0)
            {
                if(bullets.Peek() <= locks.Peek())
                {
                    bullets.Pop();
                    price+=bulletPrice;
                    locks.Dequeue();
                    barrel--;
                    Console.WriteLine("Bang!");
                }
                else
                {
                    bullets.Pop();
                     price += bulletPrice;
                    barrel--;
                    Console.WriteLine("Ping!");
                }
                if(barrel <= 0 && bullets.Count>0)
                {
                    Console.WriteLine("Reloading!");
                    if (bullets.Count >= count)
                    {
                        barrel = count;
                    }
                    else
                    {
                        barrel = bullets.Count;
                    }
                    
                }
                else if(bullets.Count <= 0)
                {
                    if(locks.Count == 0)
                    {
                        Console.WriteLine($"{bullets.Count} bullets left. Earned ${intelligence - price}");
                        return;
                    }
                    else
                    {
                        Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
                        return;
                    }
                    
                }


            }
            Console.WriteLine($"{bullets.Count} bullets left. Earned ${intelligence-price}");
        }
    }
}
