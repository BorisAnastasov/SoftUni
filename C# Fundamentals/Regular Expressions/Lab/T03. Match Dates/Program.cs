using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace T03._Match_Dates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<day>\d{2})(\.|-|\/)(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})";
            string input = Console.ReadLine();
            Regex regex = new Regex(pattern);
            MatchCollection matchCollection = regex.Matches(input);
            foreach (Match date in matchCollection)
            {
                string day = date.Groups["day"].Value;
                string month = date.Groups["month"].Value;
                string year = date.Groups["year"].Value;
                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
