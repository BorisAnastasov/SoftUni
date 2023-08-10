using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T04.PizzaCalories
{
    public class Topping
    {
        private string toppingType;
        private int grams;
        public Topping()
        {

        }
        public Topping(string toppingType, int grams)
        {
            ToppingType = toppingType;
            Grams = grams;
        }

        public string ToppingType 
        {
            get => toppingType;
            private set
            {
                switch (value.ToLower())
                {
                    case "meat":
                    case "veggies":
                    case "cheese":
                    case "sauce":
                    case "Meat":
                    case "Veggies":
                    case "Cheese":
                    case "Sauce":
                        break;
                        default:
                        throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                toppingType = value;
            } 
        }
        public int Grams
        {
            get => grams;
            private set
            {
                if(!(value>=1&&value<=50)) 
                {
                    throw new ArgumentException($"{this.toppingType} weight should be in the range [1..50].");
                }
                grams = value;
            }
        }
        public double Sum()
        {
            double sum = grams*2;
            switch (toppingType.ToLower())
            {
                case "Meat":
                    sum *= 1.2;
                    break;
                case "meat":
                    sum *= 1.2;
                    break;
                case "Veggies":
                    sum *= 0.8;
                    break;
                case "veggies":
                    sum *= 0.8;
                    break;
                case "Cheese":
                    sum *= 1.1;
                    break;
                case "cheese":
                    sum *= 1.1;
                    break;
                case "Sauce":
                    sum *= 0.9;
                    break;
                case "sauce":
                    sum *= 0.9;
                    break;
            }
            return sum;
        }
    }
}
