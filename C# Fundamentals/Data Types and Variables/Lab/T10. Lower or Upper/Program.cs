using System;

namespace T10._Lower_or_Upper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char w = char.Parse(Console.ReadLine());
            bool pr = char.IsUpper(w);
            if (pr)
            {
                Console.WriteLine("upper-case");
            }
            else
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
