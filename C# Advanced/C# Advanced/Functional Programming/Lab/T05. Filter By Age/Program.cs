using System;
using System.Collections.Generic;
using System.Linq;

namespace T05._Filter_By_Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(", ");
                people.Add(new Person() { Name = input[0], Age = int.Parse(input[1]) });
                
            }
            string filterType =Console.ReadLine();
            int filterValue = int.Parse(Console.ReadLine());
            Func<Person, int, bool> filter = GetFilter(filterType);
            people = people.Where(p => filter(p, filterValue)).ToList();
            Action<Person> formatter = GetFormatter(Console.ReadLine());
            foreach (var person in people)
            {
                formatter(person);
            }
        }
        static Func<Person, int, bool> GetFilter(string filterType)
        {
            if (filterType == "younger")
            {
                return (p, value) => p.Age < value;
            }
            else
            {
                return (p, value) => p.Age >= value;
            }
        }
        static Action<Person> GetFormatter(string formatType)
        {
            if(formatType == "name age")
            {
                return p => Console.WriteLine($"{p.Name} - {p.Age}");
            }
            else if (formatType == "name")
            {
                return p => Console.WriteLine($"{p.Name}");
            }
            else if (formatType == "age")
            {
                return p => Console.WriteLine($"{p.Age}");
            }
            return null;
        }




        class Person
        {
            public string Name;
            public int Age;
        }
    }
}
