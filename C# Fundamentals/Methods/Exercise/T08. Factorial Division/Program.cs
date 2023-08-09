using System;

namespace T08._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"{(FacA(a) / FacB(b)):f2}");
        }
        static double FacA(int a)
        {
            double sum = 1;
            for (int i = 1; i <= a; i++)
            {
                sum *= i;
            }
            return sum;
        }
        static double FacB(int b)
        {
            double sum = 1;
            for (int i = 1; i <= b; i++)
            {
                sum *= i;
            }
            return sum;
        }
    }
}
