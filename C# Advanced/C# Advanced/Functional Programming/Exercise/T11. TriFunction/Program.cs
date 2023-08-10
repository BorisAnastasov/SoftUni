using System;
using System.Linq;

namespace T11._TriFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] arr = Console.ReadLine().Split(" ").ToArray();
            Func<string, int, bool> func = (word, n) =>
            {
                int sum = 0;
                char[] chars = word.ToCharArray();
                foreach (var item in chars)
                {
                    int num = item;
                    sum += num;
                }
                return sum > n;
            };
            Func<Func<string, int, bool>, string[],int, string> result = (func, arr, n) =>
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (func(arr[i], n))
                    {
                        return arr[i];
                    }
                }
                return null;
            };
            string name = result(func, arr, n);
            Console.WriteLine(name);
        }
    }
}
