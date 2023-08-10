using System;
using System.Linq;

namespace T04._Find_Evens_or_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int start = arr[0];
            int end = arr[1];
            string cmd = Console.ReadLine();
            Predicate<int> predicateEven = number =>
            {
                if (number % 2 == 0)
                {
                    return true;
                }
                else return false;
            };
            Predicate<int> predicateOdd = number =>
            {
                if (number % 2 == 0)
                {
                    return false;
                }
                else return true;
            };
            if (cmd == "even")
            {
                for (int i = start; i <= end; i++)
                {
                    if (predicateEven(i))
                    {
                        Console.Write($"{i} ");
                    }
                }
                    
                
            }
            else
            {
                for (int i = start; i <= end; i++)
                {
                    if (predicateOdd(i))
                    {
                        Console.Write($"{i} ");
                    }
                }
            }
            
        }
    }
}
