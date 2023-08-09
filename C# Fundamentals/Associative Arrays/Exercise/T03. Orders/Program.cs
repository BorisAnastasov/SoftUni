using System;
using System.Collections.Generic;
using System.Data;

namespace T03._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split(" ");
            var list = new Dictionary<string, List<double>>();
            while (strings[0] != "buy")
            {
                string product = strings[0];
                double price = double.Parse(strings[1]);
                int quan = int.Parse(strings[2]);
                if (list.ContainsKey(product))
                {
                    list[product][1] += quan;
                    list[product][0] = price;
                }
                else
                {
                    list.Add(product, new List<double>());
                    list[product].Add(price);
                    list[product].Add(quan);
                }



                strings = Console.ReadLine().Split(" ");
            }
            foreach (var item in list)
            {
                Console.WriteLine($"{item.Key} -> {(item.Value[0] * item.Value[1]):f2}");
            }
        }
    }
}
