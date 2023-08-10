using System;
using System.Collections.Generic;

namespace T4._Matching_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string expr = Console.ReadLine();
            Stack<int> indexes = new Stack<int>();
            for (int i = 0; i < expr.Length; i++)
            {
                if (expr[i] == '(')
                {
                    indexes.Push(i);
                }
                if(expr[i] == ')')
                {
                    int start = indexes.Pop();
                    Console.WriteLine(expr.Substring(start,i-start+1));
                }
            }
        }
    }
}
