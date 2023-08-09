using System;
using System.Collections.Generic;

namespace T02._A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            var coll = new Dictionary<string, int>();
            while (text != "stop")
            {
                string res = text;
                int quan = int.Parse(Console.ReadLine());
                if (coll.ContainsKey(res))
                {
                    coll[res] += quan;
                }
                else
                {
                    coll.Add(res, quan);
                }
                text = Console.ReadLine();
            }
            foreach (var item in coll)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
