using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace T06._Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var dict = new Dictionary<string, Dictionary<string, int>>();            
            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split(" -> ");
                string color = data[0];
                string[] clothes = data[1].Split(',');
                if (!dict.ContainsKey(color))
                {
                    dict.Add(color, new Dictionary<string, int>());
                                    
                }
                foreach (var item in clothes)
                {
                    if (dict[color].ContainsKey(item))
                    {
                        dict[color][item]++;
                    }
                    else
                    {
                        dict[color].Add(item, 1);
                    }
                }
            }
            string[] lookingFor = Console.ReadLine().Split(" ").ToArray();
            string wantedColor = lookingFor[0];
            string wantedClothe = lookingFor[1];
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} clothes:");
                foreach (var i in item.Value)
                {
                    if(wantedColor == item.Key&& wantedClothe == i.Key)
                    {
                        Console.WriteLine($"* {i.Key} - {i.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {i.Key} - {i.Value}");
                    }
                    
                }
            }
        }
    }
}
