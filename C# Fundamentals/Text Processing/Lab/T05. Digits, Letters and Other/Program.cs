using System;

namespace T05._Digits__Letters_and_Other
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            char[] chars = text.ToCharArray();
            string digits = "";
            string letters = "";
            string sym = "";
            foreach (var item in chars)
            {
                if (char.IsDigit(item))
                {
                    digits += item;
                } 
                else if (char.IsLetter(item))
                {
                    letters += item;
                }
                else
                {
                    sym += item;
                }
            }
            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(sym);
        }
    }
}
