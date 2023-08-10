using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T01.Vehicles
{
    public class Car:IVehicle
    {
        private double fuelQuantity;
        private double fuelConsumption;
        public Car(double fuelQuantity, double fuelConsumption)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption+0.9;
        }

        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }
        public void Drive(double dist)
        {
            double lit = dist * this.FuelConsumption;
            if (this.FuelQuantity >= lit)
            {
                this.FuelQuantity -= lit;
                Console.WriteLine($"Car travelled {dist} km");
            }
            else
            {
                Console.WriteLine("Car needs refueling");
            }
        }
        public void Refuel(double lit)
        {
            this.FuelQuantity += lit;
        }

    }
}
