using System;
using System.Collections.Generic;
using System.Linq;
namespace T07._Append_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split('|').ToArray();
            List<string> list = new List<string>();
            for (int i = arr.Length-1; i >= 0; i--)
            {
                string[] n = arr[i].Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int j= 0; j < n.Length; j++)
                {
                    list.Add(n[j]);
                }
            }
            Console.WriteLine(String.Join(" ",list));
        }
    }
}
