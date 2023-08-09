﻿using System;

namespace T02._Print_Numbers_in_Reverse_Order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i <= numbers.Length-1; i++)
            {
                int number = int.Parse(Console.ReadLine());
                numbers[i] = number;
            }
            for (int i = numbers.Length-1; i >= 0; i--)
            {
                Console.Write($"{numbers[i]} ");
            }
            
        }
    }
}
