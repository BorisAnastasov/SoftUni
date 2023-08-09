using System;

namespace T09._Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            while(text != "END")
            {
                
                string backward = Backward(text);
                if(text == backward)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
                text = Console.ReadLine();
            }
        }
        static string Backward(string a)
        {
            int number = int.Parse(a);
            int Reverse = 0;
            while (number > 0)
            {
                int remainder = number % 10;
                Reverse = (Reverse * 10) + remainder;
                number = number / 10;
            }
            return Reverse.ToString();
        }
    }
}
