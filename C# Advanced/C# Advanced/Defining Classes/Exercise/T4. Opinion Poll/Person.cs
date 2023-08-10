using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Person
    {
        private string name;
        private int age;
        public Person(string name, int age)
        {
            this.Age = age;
            this.Name = name;
        }
        public string Name { get { return this.name; } set { this.name = value; } }
        public int Age { get { return this.age; } set { this.age = value; } }
    }
    public class Elder
    {
        private List<Person> list = new();
        public void Add(Person person) 
        { 
            this.list.Add(person);
        }
        public void Print()
        {
            foreach (var item in this.list.OrderBy(p=>p.Name))
            {
                if(item.Age > 30) 
                {
                    Console.WriteLine($"{item.Name} - {item.Age}");
                }                
            }
        }
    }
}
