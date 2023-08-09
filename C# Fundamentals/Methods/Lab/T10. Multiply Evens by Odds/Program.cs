using System;
using System.Linq;
namespace T10._Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumEven = GetSumOfEvenDigits(n);
            int sumOdd = GetSumOfOddDigits(n);
            int sum = GetMultipleOfEvenAndOdds(sumEven, sumOdd);
            Console.WriteLine(sum);
        }
        static int GetSumOfEvenDigits(int n)
        {
            int sum = 0;    
            while(n != 0)
            {
                int lastDigit = Math.Abs(n % 10);
                n /= 10;
                if(lastDigit%2 == 0)
                {
                    sum+=lastDigit;
                }
            }
            return sum;
            
        }
        static int GetSumOfOddDigits(int n)
        {
            int sum = 0;

            while (n != 0)
            {
                int lastDigit = Math.Abs(n % 10);
                n /= 10;
                if (lastDigit % 2 != 0)
                {
                    sum += lastDigit;
                }
            }
            return sum;

        }
        static int  GetMultipleOfEvenAndOdds(int sumOdd, int sumEven)
        {
            int sum = sumOdd * sumEven;
            return sum;
        }
    }
}
