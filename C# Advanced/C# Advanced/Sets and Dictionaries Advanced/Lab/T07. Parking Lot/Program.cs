using System;
using System.Collections.Generic;

namespace T07._Parking_Lot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var set = new HashSet<string>();
            string line;
            while ((line = Console.ReadLine()) !="END")
            {
                string[] arr = line.Split(", ");
                string number = arr[1];
                if (arr[0] == "IN")
                {
                    set.Add(number);
                }
                else//out
                {
                    set.Remove(number);
                }
            }
            if(set.Count > 0)
            {
                foreach (var item in set)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            
        }
    }
}
