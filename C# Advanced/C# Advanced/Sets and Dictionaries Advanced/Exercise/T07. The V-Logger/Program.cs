using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace T07._The_V_Logger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split(' ');
            var vloggers = new Dictionary<string,Vlogger>();
            while (command[0] != "Statistics")
            {
                if (command[1]  == "joined")
                {
                    if (!vloggers.ContainsKey(command[0]))
                    {
                        vloggers.Add(command[0], new Vlogger() { Following = new List<string>(), Followers = new List<string>() });
                    }
                }
                else if (command[1] == "followed")
                {
                   if(vloggers.ContainsKey(command[0]) && vloggers.ContainsKey(command[2])&& command[0] != command[2]
                   && !vloggers[command[0]].Following.Contains(command[2]))
                   {
                        vloggers[command[0]].Following.Add(command[2]);
                        vloggers[command[2]].Followers.Add(command[0]);
                   }                    
                }
                command = Console.ReadLine().Split(' ');
            }
            Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");
            int count = 1;
            foreach (var (vlogger, lists) in vloggers.OrderByDescending(x => x.Value.Followers.Count).ThenBy(x => x.Value.Following.Count))
            {
                if (count == 1)
                {
                    Console.WriteLine($"{count++}. {vlogger} : {lists.Followers.Count} followers, {lists.Following.Count} following");
                    foreach (var follower in lists.Followers.OrderBy(x => x))
                        Console.WriteLine($"*  {follower}");
                }

                else
                {
                    Console.WriteLine($"{count++}. {vlogger} : {lists.Followers.Count} followers, {lists.Following.Count} following");
                }
            }
        }
    }
    class Vlogger 
    { 
    public List<string> Followers { get; set; }
    public List<string> Following { get; set; }
    }

}
