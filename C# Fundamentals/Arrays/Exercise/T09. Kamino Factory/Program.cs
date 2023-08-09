using System;
using System.Linq;

namespace T09.Kamino_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int arrays = 0;                        
            int maxRow = 0;
            int beststartingIndex = 0;
            int maxSum = 0;
            int bestCountArray = 0;
            int[] bestArray = new int[n];
            while (input != "Clone them!")
            {
                int[] arr = input.Split("!",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                arrays++;
                int row = 1;
                int startingIndex = 0;
                int sum = 0;
                for (int i = 0; i < arr.Length-1; i++)
                {
                    if(arr[i] == 1 && arr[i] == arr[i + 1])
                    {
                        if(row == 1)
                        {
                            startingIndex = i;
                        }
                        row++;
                    }
                }
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == 1)
                    {
                        sum++;
                    }
                }
                if(row > maxRow)
                {
                    maxRow = row;
                    beststartingIndex = startingIndex; 
                    maxSum = sum;
                    bestCountArray = arrays;
                    bestArray = arr;
                }
                else if(row == maxRow)
                {
                    if(startingIndex < beststartingIndex)
                    {
                        beststartingIndex = startingIndex;
                        maxSum = sum;
                        bestCountArray = arrays;
                        bestArray = arr;
                    }
                    else if (startingIndex == beststartingIndex)
                    {
                        if(sum > maxSum)
                        {
                            maxSum = sum;
                            bestCountArray = arrays;
                            bestArray = arr;
                        }
                    }
                }
                sum = 0;
                startingIndex = 0;
                row = 1;
                input = Console.ReadLine();
            }
            Console.WriteLine($"Best DNA sample {bestCountArray} with sum: {maxSum}.");
            Console.WriteLine(string.Join(" ",bestArray));


        }
    }
}