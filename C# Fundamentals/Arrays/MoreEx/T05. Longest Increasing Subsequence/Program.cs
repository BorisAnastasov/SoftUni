using System;
using System.Linq;

namespace T05._Longest_Increasing_Subsequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] subsequence = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] bestArr = new int[subsequence.Length-1];
            for (int i = 0; i < subsequence.Length; i++)
            {

                for (int z = i; z < subsequence.Length-1; z++)
                {
                    if()
                    bestArr[z-i] =  
                }
            }
            
        }
    }
}
