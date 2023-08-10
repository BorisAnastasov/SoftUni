using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumptionPerKilometer;
        private double travelledDistance;
        public Car(string model, double fuelA, double fuelCon,double travel)
        {
            Model = model;
            FuelAmount= fuelA;
            fuelConsumptionPerKilometer= fuelCon;
            TravelledDistance= travel;

        }
        public string Model { get { return model; } set { model = value; } }
        public double FuelAmount { get { return fuelAmount; } set { fuelAmount = value; } }
        public double FueConsumptionPerKilometer { get { return fuelConsumptionPerKilometer; } set { fuelConsumptionPerKilometer = value; } }
        public double TravelledDistance { get { return travelledDistance; } set { travelledDistance = value; } }
        public static void Drive(List<Car> list,string model,double travelDis)
        {
            foreach (var item in list)
            {
                if(item.Model == model)
                {
                    if (item.fuelAmount - item.FueConsumptionPerKilometer * travelDis >= 0)
                    {
                        item.fuelAmount -= item.FueConsumptionPerKilometer * travelDis;
                        item.TravelledDistance += travelDis;
                    }
                    else
                    {
                        Console.WriteLine("Insufficient fuel for the drive");
                    }
                }
            }
        }

    }
}
