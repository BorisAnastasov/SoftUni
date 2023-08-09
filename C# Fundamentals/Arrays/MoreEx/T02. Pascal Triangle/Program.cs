using System;

namespace T02._Pascal_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int[] arr = new int[1];
            arr[0] = 1;
            int[] currArr;
            //counts the rows
            for (int rows = 1; rows <= lines; rows++)
            {
                currArr = new int[rows];
                //calculating the elements
                for (int elem = 0; elem < rows; elem++)
                {
                    if(elem == 0|| elem == rows-1)
                    {
                        currArr[elem] = 1;
                    }
                    else
                    {
                        currArr[elem] = arr[elem] + arr[elem-1];
                    }


                }
                //printing 
                for (int i = 0; i < currArr.Length; i++)
                {
                    Console.Write($"{currArr[i]} ");
                }
                Console.WriteLine();
                arr = currArr;
            }
        }
    }
}
