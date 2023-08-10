using System;
using System.Linq;
using System.Numerics;

namespace T1._Diagonal_Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            Matrix(matrix);
            int primarySum = 0;
            int secomdSum = 0;
            //calculating the primary sum
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                primarySum+=matrix[i,i];
            }
            //calculating the second sum
            for (int i = matrix.GetLength(1) - 1; i >= 0; i--)
            {
                secomdSum += matrix[i, matrix.GetLength(1) - 1-i];
            }
            int abs = Math.Abs(primarySum-secomdSum);
            Console.WriteLine(abs);
        }
        static void Matrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int col  = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = arr[col];
                }
            }
        }
    }
    
}
