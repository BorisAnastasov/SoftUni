using System;
using System.Collections.Generic;
using System.Linq;

namespace T08._SoftUni_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var set = new HashSet<string>();
            string line;
            while ((line = Console.ReadLine()) !="PARTY")
            {
                set.Add(line);
            }
            string line2;
            while ((line2 = Console.ReadLine()) != "END")
            {
                set.Remove(line2);
            }
            Console.WriteLine(set.Count);
            var guests = new HashSet<string>();
            var vip = new HashSet<string>();
            foreach (var item in set)
            {
                char[] arr = item.ToCharArray();
                if (char.IsDigit(arr[0]))
                {
                    vip.Add(item);
                }
                else
                {
                    guests.Add(item);
                }
            }
            foreach (var item in vip)
            {
                Console.WriteLine(item);
            }
            foreach (var item in guests)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
