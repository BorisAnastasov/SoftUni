using System;
using System.Data;
using System.Linq;

namespace Т1._Sum_Matrix_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];
            int[,] matrix = new int[rows, cols];
            for (int r = 0; r < rows; r++)
            {
                int[] arr = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int c = 0; c < cols; c++)
                {
                    matrix[r,c] = arr[c];
                }
            }
            Console.WriteLine(rows);
            Console.WriteLine(cols);
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    sum+= matrix[i,k];
                }
            }
            Console.WriteLine(sum);



        }
    }
}
