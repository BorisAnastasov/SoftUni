using System;

namespace T11._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            double all = 0;
            for (int i = 0; i < n; i++)
            {
                double priceCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int count = int.Parse(Console.ReadLine());
                sum = ((days * count) * priceCapsule);
                Console.WriteLine($"The price for the coffee is: ${sum:f2}");
                all += sum;
            }
            Console.WriteLine($"Total: ${all:f2}");
        }
    }
}
