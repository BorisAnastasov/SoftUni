using System;

namespace T11._Math_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            string operator1 = Console.ReadLine();
            int second = int.Parse(Console.ReadLine());
            int result = Calculate(first, operator1, second);
            Console.WriteLine(result);
        }
        static int Calculate(int a, string operator1, int b)
        {
            int result = 0;
            switch (operator1)
            {
                case "/":
                    result = a / b;
                    break;
                case "*":
                    result = a * b;
                    break;
                case "-":
                    result = a - b;
                    break;
                case "+":
                    result = a + b;
                    break;
            }

            return result;
        }
    }
}
