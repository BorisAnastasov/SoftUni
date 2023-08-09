using System;

namespace T03._Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string strings = Console.ReadLine();
            int index = strings.IndexOf(word);
            while(index != -1)
            {

                strings = strings.Remove(index, word.Length);
                index = strings.IndexOf(word);
            }
            Console.WriteLine(strings); ;
        }
    }
}
