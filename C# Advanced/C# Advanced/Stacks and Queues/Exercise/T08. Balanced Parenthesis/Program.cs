using System;
using System.Collections.Generic;
using System.Linq;

namespace T08._Balanced_Parenthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];
                if (ch == '(' || ch == '{' || ch == '[')
                {
                    stack.Push(ch);
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                    char ch2 = input[i];
                    char ch1 = stack.Pop();
                    if(!(ch1 == '('&&ch2 ==')' || ch1 == '{'&&ch2=='}' || ch1 == '[' && ch2 == ']'))
                    {
                        Console.WriteLine("NO"); return;
                    }
                }
            }
            Console.WriteLine("YES");
        }
    }
}
