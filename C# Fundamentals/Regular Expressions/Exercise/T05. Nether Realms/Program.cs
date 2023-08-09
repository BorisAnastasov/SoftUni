using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace T05._Nether_Realms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string words = Console.ReadLine();
            string pattern = @"[^\,\0\ ]+";
            MatchCollection list = Regex.Matches(words, pattern);
            List<string> names = new List<string>();
            foreach (var item in list)
            {
                names.Add(item.ToString());
            }            
            names.Sort();
            for (int i = 0; i < names.Count; i++)
            {
                
                string input = names[i];
                //HP
                string patternHP = @"[^0-9\+\-\*\/\.]+";
                MatchCollection matchcollectionHP = Regex.Matches(input, patternHP);
                string letters = "";
                foreach (var item in matchcollectionHP)
                {
                    letters += item;
                }
                int health = 0;
                for (int k = 0; k < letters.Length; k++)
                {
                    health += letters[k];
                }
                //damage
                double damage = 0;
                //adding and substracking
                string patternAddSubs = @"[0-9\+\-\.]+";
                MatchCollection match = Regex.Matches(input, patternAddSubs);
                foreach (var item in match)
                {
                    damage += double.Parse(item.ToString());
                }
                //multy and dividing
                string patternMultyDiv = @"[\/\*]+";
                MatchCollection matchMultyDiv = Regex.Matches(input, patternMultyDiv);
                string sighs = "";
                foreach (Match item in matchMultyDiv)
                {
                   sighs+=item.ToString();
                }
                for (int k = 0; k < sighs.Length; k++)
                {
                    if (sighs[k] == '*')
                    {
                        damage *= 2;
                    }
                    else
                    {
                        damage /= 2;
                    }
                }
                Console.WriteLine($"{input} - {health} health, {damage:f2} damage");
            }
        }
    }
}
