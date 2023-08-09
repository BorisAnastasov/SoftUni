using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace T01._Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>(); 
            string pattern = @"^>>(?<name>[A-Za-z]+)<<(?<price>\d+(\.\d+){0,1})!(?<quan>\d+)(\.\d+){0,1}$";
            string input;
            double sum = 0;
            while ((input = Console.ReadLine())!= "Purchase")
            {
                Match match = Regex.Match(input, pattern);
                if (match.Success)
                {
                    string name = match.Groups["name"].Value;
                    double price = double.Parse(match.Groups["price"].Value);
                    int quan = int.Parse(match.Groups["quan"].Value);
                    sum += price * quan;
                    list.Add(name);
                }
            }
            Console.WriteLine("Bought furniture:");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Total money spend: {sum:f2}");
        }
    }
}
