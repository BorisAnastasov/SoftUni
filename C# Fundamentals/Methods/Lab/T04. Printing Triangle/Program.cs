using System;

namespace T04._Printing_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n = int.Parse(Console.ReadLine());
            Up(n);
            Mid(n);
            Down(n);
        }
        static void Up(int n)
        {
            for (int i = 1; i < n; i++)
            {

                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
        }
        static void Mid(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
        static void Down(int n)
        {
            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j <= n-i; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
        }
    }
}
