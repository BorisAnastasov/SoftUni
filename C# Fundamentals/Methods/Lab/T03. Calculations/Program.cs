using System;

namespace T03._Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            Math(word, n1, n2);
        }
        static void Math(string word, int n1, int n2)
        {
            switch (word)
            {
                case "add":
                    Add(n1, n2);
                    break;
                case "multiply":
                    Multiply(n1, n2);
                    break;
                case "substract":
                    Substract(n1, n2);
                    break;
                case "divide":
                    Divide(n1, n2);
                    break;
            }
        }
        static void Add(int n1, int n2)
        {
            Console.WriteLine(n1+n2);
        }
        static void Multiply(int n1, int n2)
        {
            Console.WriteLine(n1 * n2);
        }
        static void Substract(int n1, int n2)
        {
            Console.WriteLine(n1 - n2);
        }
        static void Divide(int n1, int n2)
        {
            Console.WriteLine(n1 / n2);
        }
    }
}
