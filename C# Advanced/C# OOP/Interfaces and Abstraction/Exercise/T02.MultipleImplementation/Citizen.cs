using PersonInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  PersonInfo

{
    public class Citizen : IPerson, IIdentifiable, IBirthable
    {
        public Citizen(string name,int age, string id, string birthdate)
        {
            Age = age;
            Name = name;
            Id = id;
            Birthdate = birthdate;
        }
        public int Age { get; set; }
        public string Name { get; set; }
        public string Id { get; set; }
        public string Birthdate { get; set; }
    }
}
