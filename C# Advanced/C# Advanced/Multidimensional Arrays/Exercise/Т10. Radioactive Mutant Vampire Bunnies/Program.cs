using System;
using System.Linq;

namespace Т10._Radioactive_Mutant_Vampire_Bunnies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];
            char[,] matrix = new char[rows, cols];
            int rowPos = 0;
            int colPos = 0;
            //saving the matrix and finding the 'P'
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string text = Console.ReadLine();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = text[col];
                    if(matrix[row, col] == 'P')
                    {
                        rowPos = row;
                        colPos = col;
                    }
                }
            }

            //reading the commands
            char[] commands = Console.ReadLine().ToCharArray();

            for (int i = 0; i < commands.Length; i++)
            {
                char cmd = commands[i];
                int[] arr = Cordinates(rowPos, colPos, matrix, cmd);
                matrix = Bunnies(matrix);
                if (Dead(matrix, rowPos, colPos))
                {
                    Console.WriteLine($"dead: {rowPos} {colPos}");
                }
                rowPos = arr[0];
                colPos = arr[1];
                
                
            }
            Console.WriteLine($"won: {rowPos} {colPos}");
        }
        public static int[] Cordinates(int row, int col, char[,] matrix, char cmd)
        {
            int winORdead = 0;
            matrix[row, col] = '.';
            if (cmd == 'U')
            {
                if (row - 1 < 0)
                {
                    winORdead = 1;
                }
                else if (matrix[row - 1, col] == 'B')
                {
                    row -= 1;
                    winORdead = -1;
                }
                else
                {
                    row -= 1;
                    matrix[row, col] = 'P';
                    winORdead = 0;
                }
            }
            else if (cmd == 'D')
            {
                if (row + 1 == matrix.GetLength(0)-1)
                {
                    winORdead = 1;
                }
                else if (matrix[row + 1, col] == 'B')
                {
                    row += 1;
                    winORdead = -1;
                }
                else
                {
                    row += 1;
                    matrix[row, col] = 'P';
                    winORdead = 0;
                }
            }
            else if (cmd == 'R')
            {
                if (col + 1 == matrix.GetLength(1)-1)
                {
                    winORdead = 1;
                }
                else if (matrix[row, col + 1] == 'B')
                {
                    col += 1;
                    winORdead = -1;
                }
                else
                {
                    col += 1;
                    matrix[row, col] = 'P';
                    winORdead = 0;
                }
            }
            else if (cmd == 'L')
            {               
                if (col - 1 < 0)
                {
                    winORdead = 1;
                }
                else if (matrix[row, col - 1] == 'B')
                {
                    col -= 1;
                    winORdead = -1;
                }
                else
                {
                    col -= 1;
                    matrix[row, col] = 'P';
                    winORdead = 0;
                }
            }
            if (winORdead == 1)
            {
                Console.WriteLine($"won: {row} {col}");
                Environment.Exit(0);
            }
            else if (winORdead == -1)
            {
                Console.WriteLine($"dead: {row} {col}");
                Environment.Exit(0);
            }
            int[] arr = new int[2]
            {
                row, col
            };
            return arr;
        }
        static char[,] Bunnies(char[,] matrix)
        {
            char[,] newMatrix = matrix;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (newMatrix[row,col] == 'B')
                    {
                        //up
                        if (IsValid(row-1, col, matrix))
                        {
                            if(matrix[row - 1, col] == 'P')
                            {
                                matrix[row - 1, col] = 'B';                                
                                return newMatrix;                                    
                                
                            }
                            else
                            {
                                matrix[row - 1, col] = 'B';
                            }
                           
                        }
                        //down
                        if (IsValid(row+1, col, matrix))
                        {
                            if (matrix[row + 1, col] == 'P')
                            {
                                matrix[row + 1, col] = 'B';
                                {
                                    return newMatrix;
                                }
                            }
                            else
                            {
                                matrix[row + 1, col] = 'B';
                            }
                        }
                        //right
                        if (IsValid(row, col+1, matrix))
                        {
                            if (matrix[row , col + 1] == 'P')
                            {
                                matrix[row, col + 1] = 'B';
                                {
                                    return newMatrix;
                                }
                            }
                            else
                            {
                                matrix[row , col + 1] = 'B';
                            }
                        }
                        //left
                        if (IsValid(row, col-1, matrix))
                        {
                            if (matrix[row, col - 1] == 'P')
                            {
                                matrix[row, col - 1] = 'B';
                                {
                                    return newMatrix;
                                }
                            }
                            else
                            {
                                matrix[row, col - 1] = 'B';
                            }
                        }
                    }
                }
            }
            
            return newMatrix;
        }
        static bool Dead(char[,] matrix, int row, int col)
        {
            if(matrix[row, col] != 'P')
            {
                return true;
            }
            return false;
        }
        static bool IsValid(int row, int col, char[,] matrix)
        {
            return row >= 0 && col >= 0 && row < matrix.GetLength(0) && col < matrix.GetLength(1);
        }
    }
}
