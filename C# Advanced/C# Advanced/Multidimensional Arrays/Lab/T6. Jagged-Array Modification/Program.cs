using System;
using System.Linq;

namespace T6._Jagged_Array_Modification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int[][] jaggedArray = new int[input][];
            for (int row = 0; row < input; row++)
            {
                jaggedArray[row] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }
            string[] cmd = Console.ReadLine().Split(" ").ToArray();
            while (cmd[0] != "END")
            {
                int row = int.Parse(cmd[1]);
                int col = int.Parse(cmd[2]);
                int val = int.Parse(cmd[3]);
                if(row >= jaggedArray.Length|| col >= jaggedArray.Length || col < 0 || row < 0)
                {
                    Console.WriteLine("Invalid coordinates");
                    cmd = Console.ReadLine().Split(" ").ToArray();
                    continue;
                }
                if (cmd[0] == "Add")
                {                    
                    jaggedArray[row][col] += val;
                }
                else if (cmd[0] == "Subtract")
                {
                    jaggedArray[row][col] -= val;
                }

                cmd = Console.ReadLine().Split(" ").ToArray();
            }
            //printing
            for (int rows = 0; rows < jaggedArray.Length; rows++)
            {
                Console.WriteLine(String.Join(" ", jaggedArray[rows]));
            }
        }
    }
}
