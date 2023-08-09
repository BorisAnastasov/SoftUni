using System;

namespace T10._Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int losts = int.Parse(Console.ReadLine());
            double priceHeadset = double.Parse(Console.ReadLine());
            double priceMouse = double.Parse(Console.ReadLine());
            double priceKeyboard = double.Parse(Console.ReadLine());
            double priceDisplay = double.Parse(Console.ReadLine());
            double sum = priceDisplay * (losts / 12) + priceHeadset * (losts / 2) + priceKeyboard * (losts / 6) + priceMouse * (losts / 3);
            Console.WriteLine($"Rage expenses: {sum:f2} lv.");
        }
    }
}
