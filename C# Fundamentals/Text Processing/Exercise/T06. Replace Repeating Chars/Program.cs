using System;
using System.Collections.Generic;

namespace T06._Replace_Repeating_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            char[] ch = text.ToCharArray();
            string output = "";
            output += ch[0];
            for (int i = 0; i < ch.Length; i++)
            {
                if (output[output.Length-1] != ch[i])
                {
                    output += ch[i];
                }
            }
            Console.WriteLine(output);
        }
    }
}
