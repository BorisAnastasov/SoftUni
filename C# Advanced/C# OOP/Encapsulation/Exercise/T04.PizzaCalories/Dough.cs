using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T04.PizzaCalories
{
    public class Dough
    {
        private string flourType;
        private string bakingTechnique;
        private int grams;
        public Dough()
        {

        }
        public Dough(string flourType, string bakingTechnique, int grams)
        {
            FlourType = flourType;
            BakingTechnique = bakingTechnique;
            Grams = grams;
        }

        public string FlourType 
        { 
            get => flourType;
            private set 
            {
                switch (value.ToLower())
                {
                    case "white":
                    case "wholegrain":
                    case "White":
                    case "Wholegrain":
                        flourType = value;
                        break;
                    default:
                        throw new ArgumentException("Invalid type of dough.");                        
                }
            }
        }
        public string BakingTechnique
        {
            get => bakingTechnique;
            private set 
            {
                switch (value.ToLower())
                {
                    case "crispy":
                    case "chewy":
                    case "homemade":
                    case "Crispy":
                    case "Chewy":
                    case "Homemade":
                        bakingTechnique = value;
                        break;
                    default:
                        throw new ArgumentException("Invalid type of dough.");
                }
            }
        }
        public int Grams
        {
            get => grams;
            private set 
            {
                if (!(value >= 1 && value <= 200))
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
                grams= value;
            }
        }
        public double Sum()
        {
            double sum = this.grams*2;
            switch (this.flourType.ToLower())
            {
                case "white":
                    sum *= 1.5;
                    break;
                case "White":
                    sum *= 1.5;
                    break;
                case "wholegrain":
                    sum *= 1.0;
                    break;
                case "Wholegrain":
                    sum *= 1.0;
                    break;
            }
            switch (this.bakingTechnique.ToLower())
            {
                case "crispy":
                    sum *= 0.9;
                    break;
                case "Crispy":
                    sum *= 0.9;
                    break;
                case "Chewy":
                    sum *= 1.1;
                    break;
                case "chewy":
                    sum *= 1.1;
                    break;
                case "Homemade":
                    sum *= 1.0;
                    break;
                case "homemade":
                    sum *= 1.0;
                    break;
            }
            return sum;
        }
    }
}
