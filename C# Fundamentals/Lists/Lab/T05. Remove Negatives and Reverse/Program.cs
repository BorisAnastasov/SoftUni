using System;
using System.Collections.Generic;
using System.Linq;
namespace T05._Remove_Negatives_and_Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> num = Console.ReadLine().Split(" ").Select(double.Parse).ToList();
            for (int i = 0; i < num.Count; i++)
            {
                if (num[i] < 0)
                {
                    num.RemoveAt(i);
                    i--;
                }
            }
            if(num.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                for (int i = num.Count-1; i >= 0; i--)
                {
                    Console.Write($"{num[i]} ");
                }
              
            }
        }
    }
}
