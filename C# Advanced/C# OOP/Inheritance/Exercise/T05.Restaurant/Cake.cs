using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Cake:Dessert
    {
        private const double Grams = 250;
        private const double Calories = 1000;
        private const decimal Cakeprice = 5M;
        public Cake(string name):base(name,Cakeprice, Grams, Calories)
        {
            
        }
    }
}
