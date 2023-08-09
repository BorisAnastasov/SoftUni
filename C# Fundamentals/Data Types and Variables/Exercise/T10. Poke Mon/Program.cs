using System;

namespace T10._Poke_Mon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int count = 0;
            double r = n;
            double orgN = r/2;
            while (n >= m)
            {
                n -= m;
                count++;
                if(orgN== n && n >= y&& y !=0) {n/=y;}
            }
            if (n < 0)
            {
                n = 0;
            }
            Console.WriteLine(n);
            Console.WriteLine(count);
        }
    }
}
