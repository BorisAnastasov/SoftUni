using System;

namespace T12._Refactor_Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            bool itIsSpecial = false;
            for (int ch = 1; ch <= num; ch++)
            {
               int curr = ch;
               while (ch > 0)
               {
                   sum += ch % 10;
                   
                   ch = ch / 10;
               }
               if(sum == 5 || sum == 7 || sum == 11)
               {
                    itIsSpecial = true;
                    Console.WriteLine($"{curr} -> {itIsSpecial}");                   
               }
               else
               {
                    Console.WriteLine($"{curr} -> {itIsSpecial}");
               }
                ch = curr;
                itIsSpecial = false;
                sum = 0;
            }

        }
    }
}
