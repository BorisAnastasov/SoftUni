using System;

namespace T7._Knight_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            for (int row = 0; row < n; row++)
            {
                string arr = Console.ReadLine();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col ] = arr[col];
                }
            }
            int knightsRemoved = 0;
            while (true)
            {
                int countMostAttacking = 0;
                int rowMost = 0;
                int colMost = 0;
                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        if (matrix[row, col] == 'K')
                        {
                            int attackedKnights = CountAttackedKnights(row, col, n, matrix);
                            if (countMostAttacking < attackedKnights)
                            {
                                countMostAttacking = attackedKnights;
                                rowMost = row;
                                colMost = col;
                            }
                        }
                    }
                }
                if(countMostAttacking == 0)
                {
                    break;
                }
                else
                {
                    matrix[rowMost, colMost] = '0';
                    knightsRemoved++;
                }
            }
            Console.WriteLine(knightsRemoved);

        }
        static int CountAttackedKnights(int row, int col, int n, char[,]matrix)
        {
            int attackedKnights = 0;
            //up-left
            if(IsCellValid(row - 2, col - 1, n))
            {
                if (matrix[row - 2, col - 1] == 'K')
                {
                    attackedKnights++;
                }
            }
            //up-right
            if (IsCellValid(row - 2, col +1, n))
            {
                if (matrix[row - 2, col + 1] == 'K')
                {
                    attackedKnights++;
                }
            }

            //right-up
            if (IsCellValid(row + 1, col + 2, n))
            {
                if (matrix[row + 1, col + 2] == 'K')
                {
                    attackedKnights++;
                }
            }
            //right-down
            if (IsCellValid(row - 1, col + 2, n))
            {
                if (matrix[row - 1, col + 2] == 'K')
                {
                    attackedKnights++;
                }
            }

            //left-up
            if (IsCellValid(row + 1, col - 2, n))
            {
                if (matrix[row + 1, col - 2] == 'K')
                {
                    attackedKnights++;
                }
            }
            //left-down
            if (IsCellValid(row - 1, col - 2, n))
            {
                if (matrix[row - 1, col - 2] == 'K')
                {
                    attackedKnights++;
                }
            }

            //down-left
            if (IsCellValid(row + 2, col - 1, n))
            {
                if (matrix[row + 2, col - 1] == 'K')
                {
                    attackedKnights++;
                }
            }
            //down-right
            if (IsCellValid(row + 2, col + 1, n))
            {
                if (matrix[row + 2, col + 1] == 'K')
                {
                    attackedKnights++;
                }
            }
            return attackedKnights;
        }
        static bool IsCellValid(int row, int col, int n)
        {
            return row >= 0 &&
                   row < n &&
                   col >= 0 &&
                   col < n;
        }
    }
}
