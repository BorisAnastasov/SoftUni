using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Car
    {
        public Car(string model,
            int speed,int power,
            string type, int weight,
            int tire1Age,
            double tire1Pressure,
            int tire2Age,
            double tire2Pressure,
            int tire3Age,
            double tire3Pressure,
            int tire4Age,
            double tire4Pressure) 
        { 
            Model= model;
            Engine= new Engine(speed, power);
            Cargo= new Cargo(type, weight);
            Tyres= new Tyre[4];
            Tyres[0] = new Tyre(tire1Age, tire1Pressure);
            Tyres[1] = new Tyre(tire2Age, tire2Pressure);
            Tyres[2] = new Tyre(tire3Age, tire3Pressure);
            Tyres[3] = new Tyre(tire4Age, tire4Pressure);
        }
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public Tyre[] Tyres { get; set; }

    }
}
