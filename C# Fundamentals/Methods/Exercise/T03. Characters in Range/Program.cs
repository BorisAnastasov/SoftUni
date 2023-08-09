using System;

namespace T03._Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            char curr;
            if((int)first > (int)second)
            {
                curr = first;
                first = second;
                second = curr;
            }
            Cal(first, second);

        }
        static void Cal(char a, char b)
        {
            for (int i = (int)a+1; i < (int)b; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }

    }
}
