using System;

namespace T03._Recursive_Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n == 1 || n == 2)
            {
                Console.WriteLine(1);
                return;
            }

            int[] arr = new int[2];
            arr[0] = 1;
            arr[1] = 1;
            for (int i = 2; i < n; i++)
            {
                int currNum = arr[1];
                int newNum = arr[0] + arr[1];
                arr[0] = currNum;
                arr[1] = newNum;
            }
            Console.WriteLine(arr[1]);

            
        }
    }
}
