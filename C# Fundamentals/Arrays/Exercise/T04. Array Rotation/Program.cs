﻿using System;
using System.Linq;
namespace T04._Array_Rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            while (n>0)
            {
                int curr = arr[0];
                for (int i = 0; i < arr.Length-1; i++)
                {
                    
                    arr[i] = arr[i + 1];
                }
                arr[arr.Length-1] = curr;

                n--;
            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
