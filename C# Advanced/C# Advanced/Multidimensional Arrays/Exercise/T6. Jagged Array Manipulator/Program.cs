using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace T6._Jagged_Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] matrix = new int[n][];
            for (int i = 0; i < n; i++)
            {
                int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                matrix[i] = arr;
                
            }

            for (int i = 0; i < n-1; i++)
            {
                if (matrix[i].Length == matrix[i + 1].Length)
                {
                    for (int k = 0; k < matrix[i].Length; k++)
                    {
                        matrix[i][k] *= 2;
                    }
                    for (int k = 0; k < matrix[i+1].Length; k++)
                    {
                        matrix[i+1][k] *= 2;
                    }
                }
                else
                {
                    for (int k = 0; k < matrix[i].Length; k++)
                    {
                        matrix[i][k] /= 2;
                    }
                    for (int k = 0; k < matrix[i + 1].Length; k++)
                    {
                        matrix[i + 1][k] /= 2;
                    }
                }
            }
            string[] text = Console.ReadLine().Split(" ").ToArray();
            while (text[0] != "End")
            {
                int row = int.Parse(text[1]);
                int col = int.Parse(text[2]);
                int value = int.Parse(text[3]);
                if(row<0 || row >= matrix.GetLength(0)|| col < 0 || col >= matrix[row].Length)
                {
                    text = Console.ReadLine().Split(" ").ToArray();
                    continue;
                }
                if (text[0] == "Add")
                {
                    matrix[row][col] += value;
                }
                else if (text[0] == "Subtract")
                {
                    matrix[row][col] -= value;
                }

                text = Console.ReadLine().Split(" ").ToArray();
            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    Console.Write($"{matrix[row][col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
