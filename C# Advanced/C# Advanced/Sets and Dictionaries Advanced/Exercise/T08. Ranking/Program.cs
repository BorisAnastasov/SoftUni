using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;

namespace T08._Ranking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var contestInfo = new Dictionary<string, string>();
            string[] input = Console.ReadLine().Split(":").ToArray();
            while (input[0] != "end of contests")
            {
                string contest = input[0];
                string password = input[1];
                contestInfo.Add(contest, password);
                input = Console.ReadLine().Split(":").ToArray();
            }
            //correct

            var info = new SortedDictionary<string , Dictionary<string, int>> ();//name,[contest, points]
            string[] users = Console.ReadLine().Split("=>").ToArray();
            while (users[0] != "end of submissions")
            {
                string contest = users[0];
                string password = users[1];
                string username = users[2];
                int points = int.Parse(users[3]);
                if (contestInfo.ContainsKey(contest))
                {
                    if (contestInfo[contest] == password)
                    {
                        // pass
                        if (!info.ContainsKey(username))
                        {
                            info.Add(username, new Dictionary<string, int>());
                            info[username].Add(contest, points);
                        }
                        else
                        {
                            if (!info[username].ContainsKey(contest))
                            {
                                info[username].Add(contest, points);
                            }
                            else
                            {
                                if (info[username][contest] < points)
                                {
                                    info[username][contest] = points;
                                }
                            }
                        }                        
                    }
                }
                users = Console.ReadLine().Split("=>").ToArray();
            }
            string bestStudent = "";
            int sumBest = 0;
            foreach (var item in info)
            {
                int sum = 0;
                foreach (var i in item.Value)
                {
                    sum += i.Value;
                }
                if (sum > sumBest)
                {
                    sumBest = sum;
                    bestStudent = item.Key;
                }
            }
            Console.WriteLine($"Best candidate is {bestStudent} with total {sumBest} points.");
            Console.WriteLine("Ranking:");
            foreach (var item in info.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}");
                foreach (var i in item.Value.OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine($"#  {i.Key} -> {i.Value}");
                }
                
            }
        }
    }
}
