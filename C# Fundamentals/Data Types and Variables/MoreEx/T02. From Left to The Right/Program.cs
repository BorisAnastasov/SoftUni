using System;
using System.Linq;

namespace T02._From_Left_to_The_Right
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                long sum = 0;
                long[] numbers = Console.ReadLine().Split().Select(long.Parse).ToArray();
                if (numbers[0] >= numbers[1])
                {
                    long num = numbers[0];
                    while(num != 0)
                    {
                        long curr = num % 10;
                        sum += curr;
                        num /= 10;
                    }
                    Console.WriteLine(Math.Abs(sum));
                }
                else
                {
                    long num = numbers[1];
                    while (num != 0)
                    {
                        long curr = num % 10;
                        sum += curr;
                        num /= 10;
                    }
                    Console.WriteLine(Math.Abs(sum));
                }
            }
            

        }
    }
}
