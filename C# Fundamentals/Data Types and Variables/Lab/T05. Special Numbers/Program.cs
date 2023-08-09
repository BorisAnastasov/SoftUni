using System;

namespace T05._Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool special = false;
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                int curr = i;
                sum = 0;
                while (curr > 0)
                {
                    
                    sum += curr % 10;
                    curr /= 10;

                }
                if(sum ==5 || sum == 7 || sum == 11)
                {
                    special = true;
                    Console.WriteLine($"{i} -> {special}");
                    special = false;
                }
                else
                {
                    Console.WriteLine($"{i} -> {special}");
                }

            }
        }
    }
}
