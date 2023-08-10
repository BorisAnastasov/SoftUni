using System;
using System.Linq;
using System.Collections.Generic;

namespace T3._Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int last = 0;
            Stack<string> stack = new Stack<string>(Console.ReadLine().Split(" ").ToList());
            foreach (string item in stack)
            { 
                if(item == "-")
                {
                    sum -= 2 * last;
                }
                else if(item == "+")
                {
                    
                }
                else
                {
                    sum += int.Parse(item);
                    last = int.Parse(item);
                }
                

            }
            Console.WriteLine(sum);
        }
    }
}
