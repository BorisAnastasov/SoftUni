using System;
using System.Linq;
namespace T06._Equal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int sum1 = 0;
            int sum2 = 0;
            for (int mid = 0; mid < numbers.Length; mid++)
            {
                //след мид
                for (int j = mid+1; j < numbers.Length; j++)
                {
                    sum1 += numbers[j];
                }
                //преди мид
                for (int g = 0; g < mid; g++)
                {
                    sum2 += numbers[g];
                }
                if(sum1 == sum2)
                {
                    
                    Console.WriteLine(mid);
                    return;
                }
                sum1 = 0;
                sum2 = 0;

            }
            if(numbers.Length == 1)
            {
                Console.WriteLine(0);
                return;
            }
            Console.WriteLine("no");
        }
    }
}
