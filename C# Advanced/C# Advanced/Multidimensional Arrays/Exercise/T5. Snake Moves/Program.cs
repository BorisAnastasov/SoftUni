using System;
using System.Linq;

namespace T5._Snake_Moves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];
            string word = Console.ReadLine();
            char[,] matrix = new char[rows, cols];
            int currIndex = 0;
            for (int row = 0; row < rows; row++)
            {
                if(row%2 == 0)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        if (currIndex == word.Length)
                        {
                            currIndex = 0;
                        }
                        matrix[row, col] = word[currIndex];
                        currIndex++;
                    }
                }
                else
                {
                    for (int col = cols - 1; col >= 0; col--)
                    {
                        if(currIndex == word.Length)
                        {
                            currIndex = 0;
                        }
                        matrix[row, col] = word[currIndex];
                        currIndex++;
                    }
                }
            }
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write($"{matrix[row,col]}");
                }
                Console.WriteLine();
            }

        }
    }
}
