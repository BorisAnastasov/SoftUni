using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml;

namespace T03._SoftUni_Bar_Income
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^\%(?<name>[A-Z][a-z]+)\%[^\%\|\$\.]*?\<(?<product>\w+)\>[^\%\|\$\.]*?\|(?<quan>\d+)\|[^\%\|\$\.]*?(?<price>\d+(\.\d+)?)\$[^\%\|\$\.]*?$";
            string input;
            double sum = 0;
            List<string> list = new List<string>();
            while ((input = Console.ReadLine()) != "end of shift")
            {
                Match match = Regex.Match(input, pattern);
                if (match.Success)
                {
                    string name = match.Groups["name"].Value;
                    string product = match.Groups["product"].Value;
                    double totalPrice = int.Parse(match.Groups["quan"].Value)* double.Parse(match.Groups["price"].Value);
                    list.Add($"{name}: {product} - {totalPrice:f2}");
                    sum += totalPrice;
                }
            }
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Total income: {sum:f2}");
        }
    }
}
