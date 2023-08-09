using System;
using System.Linq;
namespace T05._Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool numB = true;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] <= arr[j])
                    {
                        numB = false;
                        break;
                    }
                    if (numB && arr.Length ==j+1)
                    {
                        Console.Write($"{arr[i]} ");
                    }
                }
                
                numB = true;
                
            }
            Console.Write($"{arr[arr.Length - 1]}");
        }
    }
}

