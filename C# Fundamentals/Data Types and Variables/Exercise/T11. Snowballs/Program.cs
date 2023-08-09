using System;
using System.Numerics;

namespace T11._Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger max = BigInteger.MinusOne;
            int mSnow = 0;
            int mTime = 0;
            int mQ = 0;
            for (int i = 0; i < n; i++)
            {
                int snow = int.Parse(Console.ReadLine());
                int time =  int.Parse(Console.ReadLine());
                int q = int.Parse(Console.ReadLine());
                BigInteger sum = BigInteger.Pow((snow / time), q);

                if(sum > max)
                {
                    max = sum;
                    mSnow = snow;
                    mTime = time;
                    mQ = q;
                }
            }
            Console.WriteLine($"{mSnow} : {mTime} = {max} ({mQ})");
        }
    }
}
