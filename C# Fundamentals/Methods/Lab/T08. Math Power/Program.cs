using System;

namespace T08._Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double b = double.Parse(Console.ReadLine());  
            int power = int.Parse(Console.ReadLine()); 
            double sum = Power(b, power);
            Console.WriteLine(sum);
        }
        static double Power(double b, int power)
        {
            return Math.Pow(b, power);

        }
    }
}
