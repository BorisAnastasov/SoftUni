using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace T9._Miner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            string[] commands = Console.ReadLine().Split(" ").ToArray();
            int allCoal = 0;
            for (int row = 0; row < n; row++)
            {
                char[] arr = Console.ReadLine().Split(" ").Select(char.Parse).ToArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = arr[col];
                    if (arr[col] == 'c')
                    {
                        allCoal++;
                    }
                }
            }           
            // cordinates
            int rowPos = 0;
            int colPos = 0;
            //finding the position of 's'
            for (int row = 0; row < n; row++)
            {                
                for (int col = 0; col < n; col++)
                {
                    if(matrix[row, col] == 's')
                    {
                        rowPos = row;
                        colPos = col;
                    }
                }
            }
            int collectedCoal = 0;
            for (int i = 0; i < commands.Length; i++)
            {
                if (commands[i] == "left")
                {
                    if (IsValid(rowPos, colPos-1, n))
                    {
                        matrix[rowPos, colPos] = '*';
                        colPos -= 1;
                        CheckingCell(rowPos, colPos, matrix);
                        if (matrix[rowPos, colPos] == 'c')
                        {
                            matrix[rowPos, colPos] = 's';
                            collectedCoal++;
                            if (collectedCoal == allCoal)
                            {
                                Console.WriteLine($"You collected all coals! ({rowPos}, {colPos})");
                                return;
                            }
                        }
                    }
                }
                else if(commands[i] == "right")
                {
                    if (IsValid(rowPos, colPos + 1, n))
                    {
                        matrix[rowPos, colPos] = '*';
                        colPos += 1;
                        CheckingCell(rowPos, colPos, matrix);
                        if (matrix[rowPos, colPos] == 'c')
                        {
                            matrix[rowPos, colPos] = 's';
                            collectedCoal++;
                            if (collectedCoal == allCoal)
                            {
                                Console.WriteLine($"You collected all coals! ({rowPos}, {colPos})");
                                return;
                            }
                        }
                    }
                }
                else if (commands[i] == "up")
                {
                    if (IsValid(rowPos-1, colPos, n))
                    {
                        matrix[rowPos, colPos] = '*';
                        rowPos -= 1;
                        CheckingCell(rowPos, colPos, matrix);
                        if (matrix[rowPos, colPos] == 'c')
                        {
                            matrix[rowPos, colPos] = 's';
                            collectedCoal++;
                            if (collectedCoal == allCoal)
                            {
                                Console.WriteLine($"You collected all coals! ({rowPos}, {colPos})");
                                return;
                            }
                        }
                    }
                }
                else if (commands[i] == "down")
                {
                    if (IsValid(rowPos+1, colPos, n))
                    {
                        matrix[rowPos, colPos] = '*';
                        rowPos += 1;
                        CheckingCell(rowPos, colPos, matrix);
                        if (matrix[rowPos, colPos] == 'c')
                        {
                            matrix[rowPos, colPos] = 's';
                            collectedCoal++;
                            if (collectedCoal == allCoal)
                            {
                                Console.WriteLine($"You collected all coals! ({rowPos}, {colPos})");
                                return;
                            }
                        }
                    }
                }
            }
            Console.WriteLine($"{allCoal-collectedCoal} coals left. ({rowPos}, {colPos})");
        }
        static bool IsValid(int row, int col,int n)
        {
            return row>=0&& col>=0 && row< n&& col< n;  
        }
        static void CheckingCell(int row, int col, char[,] matrix)
        {
            if(matrix[row, col] == '*') 
            {
                matrix[row, col] = 's';
            }
            else if (matrix[row, col] == 'e')
            {
                Console.WriteLine($"Game over! ({row}, {col})");
                Environment.Exit(0);
            }
            
        }
    }
}
