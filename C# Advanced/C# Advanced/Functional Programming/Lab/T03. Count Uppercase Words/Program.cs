using System;
using System.Linq;

namespace T03._Count_Uppercase_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Predicate<string> predicate = x => x[0] == char.ToUpper(x[0]) && char.IsLetter(x[0]);
            string[] arr = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Where(x=>predicate(x)).ToArray();
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
