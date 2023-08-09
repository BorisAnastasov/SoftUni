using System;
using System.Collections.Generic;

namespace T06._Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> list = new List<Vehicle>();
            string[] data = Console.ReadLine().Split(" ");
            double sumcarHP = 0;
            double countcarHP = 0;
            double avCar = 0;
            double sumtruckHP = 0;
            double counttruckHP = 0;
            double avTruck = 0;
            while (data[0] != "End")
            {
                Vehicle vehicle = new Vehicle()
                {
                    TypeOfVehicle = data[0],
                    Model = data[1],
                    Color = data[2],
                    HorsePower = int.Parse(data[3]),        
                };
                if (data[0] == "truck")
                {
                    vehicle.TypeOfVehicle = "Truck";
                    counttruckHP++;
                    sumtruckHP +=int.Parse(data[3]);
                    avTruck = sumtruckHP / counttruckHP;
                }
                else
                {
                    vehicle.TypeOfVehicle = "Car";
                    countcarHP++;
                    sumcarHP += int.Parse(data[3]);
                    avCar = sumcarHP / countcarHP;
                }
                list.Add(vehicle);

                data = Console.ReadLine().Split(" ");
            }
            string text = Console.ReadLine();
            while(text != "Close the Catalogue")
            {
                foreach (Vehicle vehicle in list)
                {
                    if(text == vehicle.Model)
                    {
                        Console.WriteLine($"Type: {vehicle.TypeOfVehicle}");
                        Console.WriteLine($"Model: {vehicle.Model}");
                        Console.WriteLine($"Color: {vehicle.Color}");
                        Console.WriteLine($"Horsepower: {vehicle.HorsePower}");
                        break;
                    }
                }

                text = Console.ReadLine();
            }
            Console.WriteLine($"Cars have average horsepower of: {(avCar):f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {(avTruck):f2}.");
        }
        public class Vehicle 
        { 
            public string TypeOfVehicle { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }
            public int HorsePower { get; set; }

        }

    }
}
