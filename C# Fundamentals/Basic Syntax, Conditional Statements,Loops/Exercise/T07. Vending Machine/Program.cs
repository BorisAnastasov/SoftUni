using System;

namespace T07._Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            double m = 0;
            double sum = 0;
            while(text != "Start")
            {
                m = double.Parse(text);
                if(m == 0.1 || m == 0.2 || m == 0.5 ||m == 1 || m ==2)
                {
                    
                    sum += m;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {m}");
                }
               
                text = Console.ReadLine();
            }
            string p = Console.ReadLine();
            while(p != "End")
            {
                if (p =="Nuts")
                {
                    if(sum >= 2)
                    {
                        sum -= 2;
                        Console.WriteLine("Purchased nuts");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if(p == "Water")
                {
                    if (sum >= 0.7)
                    {
                        sum -= 0.7;
                        Console.WriteLine("Purchased water");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (p == "Crisps")
                {
                    if (sum >= 1.5)
                    {
                        sum -= 1.5;
                        Console.WriteLine("Purchased crisps");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }

                }
                else if (p == "Soda")
                {
                    if (sum >= 0.8)
                    {
                        sum -= 0.8;
                        Console.WriteLine("Purchased soda");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (p == "Coke")
                {
                    if (sum >=1)
                    {
                        sum -= 1;
                        Console.WriteLine("Purchased coke");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
                p = Console.ReadLine();
            }
            Console.WriteLine($"Change: {sum:f2}");
            
        }
    }
}
