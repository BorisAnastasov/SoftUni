using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T06.FoodShortage
{
    public class Rebel:IBuyer
    {
        private string name;
        private int age;
        private string group;
        private int food;

        public Rebel(string name, int age,string group)
        {
            Name = name;
            Age = age;
            Group= group;
            Food= 0;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Group { get; set; }
        public int Food { get; private set; }
        public void BuyFood()
        {
            this.Food += 5;
        }

    }
}
