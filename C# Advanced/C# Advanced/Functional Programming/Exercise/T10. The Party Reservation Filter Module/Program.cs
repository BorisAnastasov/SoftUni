using System;
using System.Collections.Generic;
using System.Linq;

namespace T10._The_Party_Reservation_Filter_Module
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> people = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            var filters = new Dictionary<string, Predicate<string>>();
            string command = string.Empty;
            while((command = Console.ReadLine()) != "Print")
            {
                string[] tokens = command.Split(";", StringSplitOptions.RemoveEmptyEntries);
                string action = tokens[0];
                string filter = tokens[1];
                string value = tokens[2];
                if(action == "Add filter")
                {
                    filters.Add(filter + value, GetPredicate(filter, value));
                }
                else
                {
                    filters.Remove(filter + value);
                }
            }
            foreach (var filter in filters)
            {
                people.RemoveAll(filter.Value);
            }
            Console.WriteLine(String.Join(" ",people));
        }
        static Predicate<string> GetPredicate(string filter, string value)
        {
            switch (filter)
            {
                case "Starts with":
                    return p=>p.StartsWith(value);
                    break;
                case "Ends with":
                    return p => p.EndsWith(value);
                    break;
                case "Contains":
                    return p => p.Contains(value);
                    break;
                case "Length":
                    return p => p.Length == int.Parse(value);
                    break;
                default:
                    return default;
            }
        }
    }
}
