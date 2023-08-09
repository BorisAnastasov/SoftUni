using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;

namespace T02._Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(", ").ToList();
            var racers = new Dictionary<string, int>();
            string patternName = @"[A-Za-z]+";
            string patternDis = @"[0-9]+";
            foreach (var item in list)
            {
                racers.Add(item, 0);
            }
            string input;
            while((input = Console.ReadLine()) != "end of race")
            {
                string name = "";
                MatchCollection match = Regex.Matches(input, patternName);
                for (int i = 0; i < match.Count; i++)
                {
                    name += match[i];
                }
                if (racers.ContainsKey(name)) 
                {
                    int distance = 0;
                    MatchCollection matchNumbers = Regex.Matches(input, patternDis);
                    foreach (Match item in matchNumbers)
                    {
                        string word = item.ToString();
                        for (int i = 0; i < word.Length; i++)
                        {
                            distance += int.Parse(word[i].ToString());
                        }                        
                        
                    }
                    racers[name] += distance;
                }
            }
           
            string first ="";
            int max = int.MinValue;
            foreach (var item in racers)
            {
                if (item.Value > max)
                {
                    max = item.Value;
                    first = item.Key;
                }
            }
            racers.Remove(first);
            string second = "";
            max = int.MinValue;
            foreach (var item in racers)
            {
                if (item.Value > max)
                {
                    max = item.Value;
                    second = item.Key;
                }
            }
            racers.Remove(second);
            string third = "";
            max = int.MinValue;
            foreach (var item in racers)
            {
                if (item.Value > max)
                {
                    max = item.Value;
                    third = item.Key;
                }
            }
            Console.WriteLine($"1st place: {first}");
            Console.WriteLine($"2nd place: {second}");
            Console.WriteLine($"3rd place: {third}");
        }
    }
}
