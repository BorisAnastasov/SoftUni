using System;
using System.Linq;

namespace T5._Square_With_Maximum_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] matrix = new int[input[0], input[1]];
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                int[] arr = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    matrix[rows, cols] = arr[cols];
                }
            }
            int maxSum = 0;
            int[] maxRow = new int[2];
            int[] maxCol = new int[2];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    int currSum = 0;
                    if (row >= matrix.GetLength(0)-1|| cols >= matrix.GetLength(1) - 1)
                    {
                        continue;
                    }
                    currSum += matrix[row, cols];
                    currSum += matrix[row+1, cols];
                    currSum += matrix[row , cols+1];
                    currSum += matrix[row + 1, cols+1];
                    if(currSum > maxSum)
                    {
                        maxSum = currSum;
                        maxRow[0] = matrix[row, cols];
                        maxRow[1] = matrix[row, cols+1];
                        maxCol[0] = matrix[row+1, cols];
                        maxCol[1] = matrix[row+1, cols+1];

                    }
                }
            }
            Console.WriteLine(String.Join(" ",maxRow));
            Console.WriteLine(String.Join(" ", maxCol));
            Console.WriteLine(maxSum);
        }
    }
}
