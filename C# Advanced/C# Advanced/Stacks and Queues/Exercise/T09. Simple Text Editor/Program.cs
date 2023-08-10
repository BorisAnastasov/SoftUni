using System;
using System.Collections.Generic;
using System.Linq;

namespace T09._Simple_Text_Editor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<string> stack = new Stack<string>();
            string text = string.Empty;
            for (int i = 0; i < n; i++)
            {
                string[] cmd = Console.ReadLine().Split(" ").ToArray();
                switch (cmd[0])
                {
                    case "1":
                        stack.Push(text);
                        text += cmd[1];
                        break;
                    case "2":
                        stack.Push(text);
                        int count = int.Parse(cmd[1]);
                        text = text.Substring(0, text.Length - count);
                        break;
                    case "3":
                        int index = int.Parse(cmd[1]) - 1;
                        char ch = text.ElementAt(index);
                        Console.WriteLine(ch);
                        break;
                    case "4":
                        text = stack.Pop();
                        break;
                }
            }
        }
    }
}