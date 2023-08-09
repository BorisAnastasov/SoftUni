using System;

namespace T03._Floating_Equality
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            bool ch = Math.Abs(a - b) < 0.000001;

            Console.WriteLine(ch);
        }
    }
}
