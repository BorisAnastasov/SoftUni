using System;
using System.Numerics;

namespace T7._Pascal_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            BigInteger[][] jaggedArray = new BigInteger[(int)n][];
            jaggedArray[0] = new BigInteger[1] {1};
            for (int rows = 1; rows < n; rows++)
            {
                jaggedArray[rows] = new BigInteger[jaggedArray[rows-1].Length+1];
                for (int i = 0; i < jaggedArray[rows].Length; i++)
                {
                    if (i == 0 || i == jaggedArray[rows].Length - 1)
                    {
                        jaggedArray[rows][i] = 1;
                    }
                    else
                    {
                        jaggedArray[rows][i] = jaggedArray[rows - 1][i-1]+ jaggedArray[rows - 1][i];
                    }
                }
            }
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.WriteLine(String.Join(" ", jaggedArray[i]));
            }
        }
    }
}
