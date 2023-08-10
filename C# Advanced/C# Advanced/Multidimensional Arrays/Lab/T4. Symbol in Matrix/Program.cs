using System;
using System.Linq;

namespace T4._Symbol_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            char[,] matrix = new char[input, input];
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                char[] arr = Console.ReadLine().ToCharArray();
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    matrix[rows, cols] = arr[cols];
                }
            }
            char ch = char.Parse(Console.ReadLine());
            bool exists = false;
            int cordRow = 0;
            int cordCols = 0;
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {                
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    if(matrix[rows, cols] == ch)
                    {
                        exists = true;
                        cordCols = cols;
                        cordRow = rows;
                        break; 
                    }
                }
                if (exists)
                {
                    break;
                }
            }
            if (exists)
            {
                Console.WriteLine($"({cordRow}, {cordCols})");
            }
            else
            {
                Console.WriteLine($"{ch} does not occur in the matrix");
            }
        }
    }
}
