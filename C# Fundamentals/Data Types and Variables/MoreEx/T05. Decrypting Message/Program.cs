using System;

namespace T05._Decrypting_Message
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            string word = "";
            for (int i = 0; i < n; i++)
            {
                char ch = char.Parse(Console.ReadLine());
                int index = (int)ch + key;
                char newCh = (char)index;
                word += newCh;
            }
            Console.WriteLine(word);
        }
    }
}
