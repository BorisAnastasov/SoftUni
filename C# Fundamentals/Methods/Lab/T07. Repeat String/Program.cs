using System;

namespace T07._Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Work();
        }
        static void Work()
        {
            string t = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write(t);
            }
        }

    }
}
