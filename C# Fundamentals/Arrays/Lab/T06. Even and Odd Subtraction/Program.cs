using System;
using System.Linq;
namespace T06._Even_and_Odd_Subtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int sumE = 0;
            int sumO = 0;
            
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    sumE += array[i];
                }
                else
                {
                    sumO += array[i];
                }
            }
            Console.WriteLine(sumE-sumO);
        }
    }
}
