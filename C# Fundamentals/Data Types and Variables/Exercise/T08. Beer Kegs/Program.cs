using System;

namespace T08._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double max = double.MinValue;
            string maxM = "";
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                float rad = float.Parse(Console.ReadLine());
                int h = int.Parse(Console.ReadLine());
                 sum = h * rad*rad*Math.PI;
                if(sum > max)
                {
                    max = sum;
                    maxM = model;

                }
            }
            Console.WriteLine(maxM);
        }
    }
}
