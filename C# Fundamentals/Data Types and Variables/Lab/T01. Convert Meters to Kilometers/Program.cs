using System;

namespace T01._Convert_Meters_to_Kilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double m = double.Parse(Console.ReadLine());
            double km = m / 1000;
            Console.WriteLine($"{km:f2}");
        }
    }
}
