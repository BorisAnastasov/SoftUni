using System;
using System.Linq;

namespace T2._Squares_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            char[,] matrix = new char[arr[0], arr[1]];
            Matrix(matrix);
            int count = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if(row == matrix.GetLength(0) - 1)
                {
                    continue;
                }
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if(col == matrix.GetLength(1)-1)
                    {
                        continue;
                    }
                    else
                    {
                        if (matrix[row,col] == matrix[row, col+1] 
                            && matrix[row+1, col + 1] == matrix[row + 1, col] 
                            && matrix[row, col]== matrix[row + 1, col + 1])
                        {
                            count++;
                        }
                    }
                    
                }
            }
            Console.WriteLine(count);
        }
        static void Matrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] arr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = arr[col];
                }
            }
        }
    }
}
