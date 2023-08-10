using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T06.FoodShortage;

namespace T04.BorderControl
{
    public class Citizen:IBuyer
    {
        private string name;
        private int age;
        private string id;
        private string birthdate;
        private int food;

        public Citizen(string name, int age, string id, string birthdate)
        {
            Name = name;
            Age = age;
            Id = id;
            BirthDate = birthdate;
            Food = 0;
        }
        public string BirthDate { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Id { get; set; }
        public int Food { get; private set;}
        public void BuyFood()
        {
            this.Food += 10;
        }
    }
}
