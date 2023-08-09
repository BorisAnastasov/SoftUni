using System;

namespace T01._Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            Min(first, second, third);
        }
        static void Min(int a,int b, int c)
        {
            int min = int.MaxValue;
            if(min > a) min = a;
            if(min > b) min = b;
            if(min > c) min = c;
            Console.WriteLine(min);
        }
    }
}
