using System;
using System.Collections.Generic;
using System.Linq;

namespace T07._Order_by_Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();
            int id = 0;
            string[] data = Console.ReadLine().Split(" ");
            while (data[0] != "End")
            {
                Person person = new Person();
                id = int.Parse(data[1]);
                RepeatingID(list, id);
                if(isThere(list, id))
                {
                    foreach (var person1 in list)
                    {
                        if (person.Id == id)
                        {
                            person.Id = id;
                            person.Name = data[0];
                            person.Age = int.Parse(data[2]);
                        }
                    }
                }
                else
                {
                    person = new Person()
                    {
                        Name = data[0],
                        Id = int.Parse(data[1]),
                        Age = int.Parse(data[2]),
                    };
                    list.Add(person);
                }    
                data = Console.ReadLine().Split(" ");
            }
            foreach (Person person in list.OrderBy(x =>x.Age))
            {
                Console.WriteLine($"{person.Name} with ID: {person.Id} is {person.Age} years old.");
            }
        }
        static bool isThere(List<Person> list, int id)
        {
            foreach (Person person in list)
            {
                if (person.Id == id)
                {
                    person.Id = id;
                    return true;
                    
                }
            }
            return false;
        }
        static void RepeatingID( List<Person> list,int id)
        {
            foreach (Person person in list)
            {
                if (person.Id == id)
                {
                    person.Id = id;

                }
            }

        }
        public class Person
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
        }
    }
}
