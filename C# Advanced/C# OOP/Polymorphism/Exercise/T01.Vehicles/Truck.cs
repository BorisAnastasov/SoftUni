using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T01.Vehicles
{
    public class Truck:IVehicle
    {
        private double fuelQuantity;
        private double fuelConsumption;
        public Truck(double fuelQuantity, double fuelConsumption)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption+1.6;
        }

        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }
        public void Drive(double dist)
        {
            double lit = dist * FuelConsumption;
            if (this.FuelQuantity >= lit)
            {
                this.FuelQuantity -= lit;
                Console.WriteLine($"Truck travelled {dist} km");
            }
            else
            {
                Console.WriteLine("Truck needs refueling");
            }
        }
        public void Refuel(double lit)
        {
            lit *= 0.95;
            this.FuelQuantity += lit;
        }
    }
}
