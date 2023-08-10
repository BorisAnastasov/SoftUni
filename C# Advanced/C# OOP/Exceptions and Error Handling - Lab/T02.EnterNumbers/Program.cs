using System;

namespace T02.EnterNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<int> numbers = new List<int>();
            while (numbers.Count < 10)
            {
                try
                {
                    int num = int.Parse(input);
                    if(numbers.Count== 0)
                    {
                        ReadNumber(1,num);
                        OverflowException oe = ReadNumber(1, num);
                        if (oe != null)
                        {
                            throw oe;
                        }
                    }
                    else
                    {
                        OverflowException oe = ReadNumber(numbers[numbers.Count-1], num);
                        if(oe != null)
                        {
                            throw oe;
                        }                          
                    }
                    numbers.Add(num);
                }
                catch (FormatException ex )
                {
                    Console.WriteLine("Invalid Number!");
                }
                catch(OverflowException ex) 
                {
                    Console.WriteLine(ex.Message);                
                }
                input= Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ",numbers));
        }
        public static OverflowException ReadNumber(int start,int num)
        {
            if (num <= start || num >= 100)
            {
                return new OverflowException($"Your number is not in range {start} - 100!");
            }
            return null;
        }
    }
}