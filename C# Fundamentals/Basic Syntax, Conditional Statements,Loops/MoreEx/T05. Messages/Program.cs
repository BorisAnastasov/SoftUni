using System;

namespace T05._Messages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string word = "";
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                int count = 0;
                int digit = number % 10;
                int index = 0;
                int offset = 0;
                while (number > 0)
                {
                    number /= 10;
                    count++;

                }
                if (digit != 8 && digit != 9&&digit!=0) 
                {
                   offset = (digit - 2) * 3;


                }
                else if(digit == 0)
                {
                    word += " ";
                    continue;
                }
                else
                {
                    offset = (digit - 2) * 3+1;
                }
                index = offset + count - 1;
                index += 97;
                char ch = (char)index;
                word += ch;
            }
            Console.WriteLine(word);
        }
    }
}
