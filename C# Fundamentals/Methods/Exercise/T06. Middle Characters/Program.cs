using System;

namespace T06._Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            bool midIsOne = Mid(word);
            MiddleIndex(word,midIsOne);
        }
        static bool Mid(string word)
        {
            if(word.Length% 2 == 0)
            {
                return false;
            }
            return true;
        }
        static void MiddleIndex(string word, bool a)
        {
            
            if (a)
            {
                int index = word.Length/2;
                Console.WriteLine(word[index]);
            }
            else
            {
                int index = word.Length / 2 ;
                Console.WriteLine($"{word[index-1]}{word[index]}");
            }

        }
    }
}
