using System;

namespace T04._Back_in_30_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minute = int.Parse(Console.ReadLine());
            minute += 30;
            if(minute >= 60)
            {
                hour++;
                minute -= 60;
                if(hour == 24)
                {
                    hour = 0;
                }
            }
            Console.WriteLine($"{hour}:{minute:d2}");
        }
    }
}
