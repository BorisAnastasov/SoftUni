using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace T8._Bombs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            for (int row = 0; row < n; row++)
            {
                int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = arr[col];
                }
            }
            string[] cordinates = Console.ReadLine().Split(" ").ToArray();
            for (int i = 0; i < cordinates.Length; i++)
            {
                int[] arr = cordinates[i].Split(",").Select(int.Parse).ToArray();
                int row = arr[0];
                int col = arr[1];
                int expl = matrix[row, col];
                if (matrix[row,col] > 0)
                {
                    BombExplosion(row, col, n, matrix, expl);
                }
                
                
            }
            int count = 0;
            int sum = 0;
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (matrix[row, col] > 0)
                    {
                        count++;
                        sum += matrix[row, col];
                    }
                }
            }
            Console.WriteLine($"Alive cells: {count}");
            Console.WriteLine($"Sum: {sum}");
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write($"{matrix[row,col]} ");
                }
                Console.WriteLine();
            }
        }
        static void BombExplosion(int row, int col, int n, int[,] matrix,int expl)
        {
            if(IsCellValid(row-1,col, n, matrix))
            {
                matrix[row - 1, col] -= expl;
            }
            if (IsCellValid(row - 1, col+1, n, matrix))
            {
                matrix[row - 1, col+1] -= expl;
            }
            if (IsCellValid(row , col+1, n, matrix))
            {
                matrix[row , col+1] -= expl;
            }
            if (IsCellValid(row +1, col+1, n, matrix))
            {
                matrix[row + 1, col+1] -= expl;
            }
            if (IsCellValid(row + 1, col, n, matrix))
            {
                matrix[row + 1, col] -= expl;
            }
            if (IsCellValid(row + 1, col-1, n, matrix))
            {
                matrix[row + 1, col-1] -= expl;
            }
            if (IsCellValid(row, col-1, n, matrix))
            {
                matrix[row, col-1] -= expl;
            }
            if (IsCellValid(row - 1, col-1, n, matrix))
            {
                matrix[row - 1, col-1] -= expl;
            }
            matrix[row, col] = 0;
        }
        static bool IsCellValid(int row, int col, int n, int[,] matrix)
        {
            return row >= 0 &&
                   row < n &&
                   col >= 0 &&
                   col < n && 
                   matrix[row,col]>0;
        }
    }
}
