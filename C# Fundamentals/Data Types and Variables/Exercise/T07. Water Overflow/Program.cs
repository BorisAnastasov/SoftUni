using System;

namespace T07._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int needed = 255;
            for (int i = 0; i < n; i++)
            {
                int m = int.Parse(Console.ReadLine());
                if(m<= needed)
                {
                    sum += m;
                    needed -= m;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                

            }
            Console.WriteLine($"{sum}");
            
        }
    }
}
