using System;
using System.Linq;

namespace T01._Reverse_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            while(text != "end")
            {
                string reversed = "";
                for (int i = text.Length-1; i >= 0; i--)
                {
                    reversed += text[i];
                }
                Console.WriteLine($"{text} = {reversed}");
                text = Console.ReadLine();
            }
        }
    }
}
