using System;
using System.Text.RegularExpressions;

namespace T02._Match_Phone_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+\b359(-| )2\1\d{3}\1\d{4}\b";
            string input = Console.ReadLine();
            Regex regex = new Regex(pattern);
            MatchCollection matchCollection = regex.Matches(input);
            Console.WriteLine(string.Join(", ",matchCollection));
        }
    }
}
