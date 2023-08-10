using System;
using System.Linq;

namespace T4._Matrix_Shuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string[,] matrix = new string[arr[0], arr[1]];
            Matrix(matrix);
            string[] str = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            int lengthRow = matrix.GetLength(0) - 1;
            int lengthCol = matrix.GetLength(1) - 1;
            while (str[0] != "END")
            {
                if(str[0] != "swap"|| str.Length-1 !=4)
                {
                    Console.WriteLine("Invalid input!");
                }
                else
                {
                    int row1 = int.Parse(str[1]);
                    int col1 = int.Parse(str[2]);
                    int row2 = int.Parse(str[3]);
                    int col2 = int.Parse(str[4]);
                    if (row1 <= lengthRow && row1 >= 0 &&
                       col1 <= lengthCol && col1 >= 0 &&
                       row2 <= lengthRow && row2 >= 0 &&
                       col2 <= lengthCol && col2 >= 0
                       )
                    {
                        string curr = matrix[row1, col1];
                        matrix[row1, col1] = matrix[row2, col2];
                        matrix[row2, col2] = curr;
                        for (int row = 0; row < matrix.GetLength(0); row++)
                        {
                            for (int col = 0; col < matrix.GetLength(1); col++)
                            {
                                Console.Write($"{matrix[row, col]} ");
                            }
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                        str = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                        continue;
                    }
                    
                }
                str = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            }

        }
        static void Matrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] arr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = arr[col];
                }
            }
        }
    }
}
