using System;

namespace T07._NxN_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Filler(n);
        }
        static void Filler(int a)
        {
            for (int i = 1; i <= a; i++)
            {
                for (int j = 1; j <= a; j++)
                {
                    Console.Write($"{a} ");
                }
                Console.WriteLine();
            }
        }
    }
}
