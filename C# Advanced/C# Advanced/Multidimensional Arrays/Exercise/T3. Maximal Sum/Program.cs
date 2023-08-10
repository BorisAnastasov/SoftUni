using System;
using System.Linq;

namespace T3._Maximal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[,] matrix = new int[arr[0], arr[1]];
            Matrix(matrix);
            int maxSum = int.MinValue;
            int[] row1 = new int[3];
            int[] row2 = new int[3];
            int[] row3 = new int[3];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    int currSum = 0;
                    if(row+1 >= matrix.GetLength(0)-1||col+1 >= matrix.GetLength(1) - 1)
                    {
                        continue;
                    }
                    else
                    {
                        currSum += matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                            + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                            + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row+2, col+2];
                    }
                    if(currSum > maxSum)
                    {
                        maxSum = currSum;

                        row1[0] = matrix[row, col];
                        row1[1] = matrix[row, col + 1];
                        row1[2] = matrix[row, col + 2];

                        row2[0] = matrix[row + 1, col];
                        row2[1] = matrix[row + 1, col + 1];
                        row2[2] = matrix[row + 1, col + 2];

                        row3[0] = matrix[row + 2, col];
                        row3[1] = matrix[row + 2, col + 1];
                        row3[2] = matrix[row + 2, col + 2];
                    }
                }
            }
            Console.WriteLine($"Sum = {maxSum}");
            Console.WriteLine(String.Join(" ",row1));
            Console.WriteLine(String.Join(" ", row2));
            Console.WriteLine(String.Join(" ", row3));
        }
        static void Matrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] arr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = arr[col];
                }
            }
        }
    }
}
