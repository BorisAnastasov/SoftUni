using System;
using System.Text.RegularExpressions;

namespace T01._Match_Full_Name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string regex1 = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            string input = Console.ReadLine();
            Regex regex = new Regex(regex1);
            MatchCollection match = regex.Matches(input);
            foreach (var name in match)
            {
                Console.Write($"{name} ");
            }
        }
    }
}
