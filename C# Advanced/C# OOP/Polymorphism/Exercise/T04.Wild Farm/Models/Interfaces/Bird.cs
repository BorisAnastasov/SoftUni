using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T04.Wild_Farm.Models.Interfaces
{
    public abstract class Bird:Animal
    {
        public Bird(string name, double weight,double wingSize):base(name, weight)
        {
                WingSize = wingSize;
        }
        public double WingSize { get; set; }
        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.WingSize}, {this.Weight}, {this.FoodEaten}]"; 
        }
    }
}
