using System;

namespace T12._Even_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            while (n % 2 != 0)
            {
                Console.WriteLine("Please write an even number.");

                n = int.Parse(Console.ReadLine());  
            }
            if(!(n > 0))
            {
                n = n * (-1);
            }
            
            Console.WriteLine($"The number is: {n}");
        }
    }
}
