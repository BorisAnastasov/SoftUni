using System;

namespace T09._Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            int count = int.Parse(Console.ReadLine());
            double priceLightsabers = double.Parse(Console.ReadLine());
            double priceRobes = double.Parse(Console.ReadLine());
            double priceBelts = double.Parse(Console.ReadLine());
            int newCount = 0;
            if (count >= 6)
            {
                newCount =count / 6;
            }
            double sum = priceLightsabers*Math.Ceiling(count*1.1) + (count-newCount)*priceBelts+count*priceRobes;
            if(sum <= budjet)
            {
                Console.WriteLine($"The money is enough - it would cost {sum:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {(sum-budjet):f2}lv more.");
            }
        }
    }
}
