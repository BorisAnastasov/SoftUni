using System;

namespace T11._Refactor_Volume_of_Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dul = double.Parse(Console.ReadLine());
            double sh = double.Parse(Console.ReadLine());
            double a = double.Parse(Console.ReadLine());
             double V = dul*sh*a/3;
            Console.Write($"Length: ");           
            Console.Write($"Width: ");            
            Console.Write($"Height: ");                      
            Console.Write($"Pyramid Volume: {V:f2}");

        }
    }
}
