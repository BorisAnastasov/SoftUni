using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace T04._Star_Enigma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string path = @"[starSTAR]+";
            int count = 0;
            List<string> attacked = new List<string>();
            List<string> destroyed = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string message = Console.ReadLine();
                MatchCollection matchCollection = Regex.Matches(message, path);
                string letters = "";
                foreach (var item in matchCollection)
                {
                    letters += item;
                }
                string newMess = "";
                count = letters.Length;
                for (int l = 0; l < message.Length; l++)
                {
                    int dig = message[l] - count;
                    newMess += (char)dig;
                }
                //PQ@Alderaa1:30000!A!->20000
                //@Cantonica: 3000!D!->4000NM
                string pattern = @"[^\@\-\!\:\>]*?@(?<name>[A-Z][a-z]+)[^\@\-\!\:\>]*?:(?<population>[0-9]+)[^\@\-\!\:\>]*?!(?<type>[AD])![^\@\-\!\:\>]*?->(?<count>[0-9]+)[^\@\-\!\:\>]*?";
                Match match = Regex.Match(newMess, pattern);
                if (match.Success)
                {
                    string name = match.Groups["name"].Value;
                    int population = int.Parse(match.Groups["population"].Value);
                    string type = match.Groups["type"].Value;
                    if (type == "A")
                    {
                        type = "attack";
                        attacked.Add(name);
                    }
                    else
                    {
                        type = "destruction";
                        destroyed.Add(name);
                    }
                    int soldiers = int.Parse(match.Groups["count"].Value);
                }
                

            }
            Console.WriteLine($"Attacked planets: {attacked.Count}");
            attacked.Sort();
            foreach (var item in attacked)
            {
                Console.WriteLine($"-> {item}");
            }
            Console.WriteLine($"Destroyed planets: {destroyed.Count}");
            destroyed.Sort();
            foreach (var item in destroyed)
            {
                Console.WriteLine($"-> {item}");
            }

        }
    }
}
