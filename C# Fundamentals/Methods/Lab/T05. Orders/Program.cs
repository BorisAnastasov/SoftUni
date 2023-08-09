using System;

namespace T05._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int n  = int.Parse(Console.ReadLine());
            Price(product, n);
        }
        static void Price(string product, int n)
        {
            double sum = 0; 
            switch (product)
            {
                case "coffee":
                    sum = 1.50*n;
                    break;
                case "water":
                    sum = 1.00 * n;
                    break;
                case "coke":
                    sum = 1.40 * n;
                    break;
                case "snacks":
                    sum = 2.00 * n;
                    break;
            }
            Console.WriteLine($"{sum:f2}"); 
        }
    }
}
