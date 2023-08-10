using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.ConstrainedExecution;

namespace T09._Predicate_Party_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(" ").ToList();
            string[] cmds = Console.ReadLine().Split(" ").ToArray();
            
            Func<List<string>, string[], List<string>> func = (list, cmds) =>
            {
                List<string> result = new List<string>();
                string type = cmds[1];
                if(type == "StartsWith")
                {
                    string substring = cmds[2];
                    foreach (var item in list)
                    {
                        if (item.StartsWith(substring))
                        {
                            result.Add(item);
                        }
                    }
                }
                else if(type == "EndsWith")
                {
                    string substring = cmds[2];
                    foreach (var item in list)
                    {
                        if (item.EndsWith(substring))
                        {
                            result.Add(item);
                        }
                    }
                }
                else if(type == "Length")
                {
                    int lenght = int.Parse(cmds[2]);
                    foreach (var item in list)
                    {
                        if (item.Length == lenght)
                        {
                            result.Add(item);
                        }
                    }
                }
                return result;
            };
            while (cmds[0] != "Party!")
            {
                List<string> final = new List<string>();
                List<string> result = new List<string>();
                string type = cmds[0];
                result = func(list, cmds);
                if (type == "Remove")
                {
                    foreach (var item in list)
                    {
                        if (!result.Contains(item))
                        {
                            final.Add(item);
                        }
                    }
                }
                else if (type == "Double")
                {
                    foreach (var item in list)
                    {
                        if (result.Contains(item))
                        {
                            final.Add(item);
                            final.Add(item);
                        }
                        else
                        {
                            final.Add(item);
                        }
                    }
                }
                list = final;
                

                cmds = Console.ReadLine().Split(" ").ToArray();
            }
            if (list.Count == 0)
            {
                Console.WriteLine("Nobody is going to the party!");
            }
            else
            {
                Console.WriteLine($"{string.Join(", ", list)} are going to the party!");
            }
        }
    }
}
