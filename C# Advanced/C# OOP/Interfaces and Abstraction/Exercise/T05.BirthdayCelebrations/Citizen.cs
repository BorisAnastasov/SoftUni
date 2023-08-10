using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T04.BorderControl
{
    public class Citizen:IData,IBirthdate
    {
        private string name;
        private int age;
        private string id;
        private string birthdate;

        public Citizen(string name, int age, string id, string birthdate)
        {
            Name = name;
            Age = age;
            Id = id;
            BirthDate = birthdate;
        }
        public string BirthDate { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Id { get; set; }
    }
}
