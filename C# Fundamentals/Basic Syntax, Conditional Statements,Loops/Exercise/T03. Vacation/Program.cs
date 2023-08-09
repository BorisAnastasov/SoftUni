using System;

namespace T03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string group  = Console.ReadLine();
            string dayOfTheWeek = Console.ReadLine();
            double sum = 0;
            if(group == "Students")
            {
                if(dayOfTheWeek == "Friday")
                {
                    sum = 8.45;
                }
                else if(dayOfTheWeek == "Saturday")
                {
                    sum = 9.80;
                }
                else if(dayOfTheWeek == "Sunday")
                {
                    sum = 10.46;
                }
                if(count >= 30)
                {
                    sum *= 0.85; 
                }
            }
            else if(group == "Business")
            {
                if (dayOfTheWeek == "Friday")
                {
                    sum = 10.90;
                }
                else if (dayOfTheWeek == "Saturday")
                {
                    sum = 15.60;
                }
                else if (dayOfTheWeek == "Sunday")
                {
                    sum = 16;
                }
                if(count >= 100)
                {
                    count -= 10;
                }
            }
            else if(group == "Regular")
            {
                if (dayOfTheWeek == "Friday")
                {
                    sum = 15;
                }
                else if (dayOfTheWeek == "Saturday")
                {
                    sum = 20;
                }
                else if (dayOfTheWeek == "Sunday")
                {
                    sum = 22.50;
                }
                if(count >= 10 && count <= 20)
                {
                    sum *= 0.95;
                }
            }
            sum = sum * count;
            Console.WriteLine($"Total price: {sum:f2}");

        }
    }
}
