using System;

namespace T04._RefactoringPrimeChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 2; i <= n; i++)
            {
                bool isPrime = true;
                for (int r = 2; r < i; r++)
                {
                    if (i % r == 0)
                    {
                        isPrime = false;
                        
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine("{0} -> true", i);
                }
                else
                {
                    Console.WriteLine("{0} -> false", i);
                }
                
            }


        }
    }
}
