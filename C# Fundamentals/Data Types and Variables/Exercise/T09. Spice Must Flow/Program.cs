using System;

namespace T09._Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());
            int sum = 0;
            int days = 0;
            while(yield >= 100)
            {
                sum += yield;
                sum -= 26;
                yield-=10;
                days++;
            }
            Console.WriteLine(days);
            if(sum > 26)
            {
                Console.WriteLine(sum - 26);
            }
            else 
            {
                Console.WriteLine(0);
            }
        }
           
    }
}
