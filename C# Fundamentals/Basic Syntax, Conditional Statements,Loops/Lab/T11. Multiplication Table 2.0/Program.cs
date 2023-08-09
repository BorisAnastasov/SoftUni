using System;

namespace T11._Multiplication_Table_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());  
            int sum = 0;
            if (m > 10)
            {
                sum = m * n;
                Console.WriteLine($"{n} X {m} = {sum}");
                return;
            }
            for (int i = m; i <= 10; i++)
            {
                if(m > 10)
                {

                }
                sum = i * n;
                Console.WriteLine($"{n} X {i} = {sum}");
            }
        }
    }
}
