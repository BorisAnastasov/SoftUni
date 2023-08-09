using System;

namespace T05._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int sum = Sum(n1, n2);
            int sum2 = Substract(n3,sum);
            Console.WriteLine(sum2);
        }
        static int Sum(int n1, int n2)
        {
            return n1 + n2;
        }
        static int Substract(int n3, int sum)
        {
            return sum - n3;
        }
    }
}
