using System;
using System.Collections.Generic;

namespace T04._Product_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dictionary =new  SortedDictionary<string, Dictionary<string, double>>();
            string line;
            while((line = Console.ReadLine()) != "Revision")
            {
                string[] info = line.Split(", ");
                string shop = info[0];
                string product = info[1];
                double price = double.Parse(info[2]);
                if (dictionary.ContainsKey(shop))
                {
                    dictionary[shop].Add(product, price);
                }
                else
                {
                    dictionary[shop] = new Dictionary<string, double>();
                    dictionary[shop].Add(product, price);
                }
            }
            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key}->");
                foreach (var i in item.Value)
                {
                    Console.WriteLine($"Product: {i.Key}, Price: {i.Value}");
                }
            }
        }
    }
}
