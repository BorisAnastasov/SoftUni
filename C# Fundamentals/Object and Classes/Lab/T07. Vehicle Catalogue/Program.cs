using System;
using System.Collections.Generic;
using System.Linq;

namespace T07._Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Catalog catalog = new Catalog();
            string text = Console.ReadLine();
            while (text != "end")
            {
                string[] arr = text.Split('/');
                if (arr[0] == "Car")
                {
                    Car car = new Car()
                    {
                        Brand = arr[1],
                        Model = arr[2],
                        HorsePower = int.Parse(arr[3])
                    };
                    catalog.Cars.Add(car);
                }
                else
                {
                    Truck truck = new Truck()
                    {
                        Brand = arr[1],
                        Model = arr[2],
                        Weight = int.Parse(arr[3])
                    };
                    catalog.Trucks.Add(truck);
                }
                text = Console.ReadLine();
            }
            if (catalog.Cars.Count > 0)
            {
                catalog.Cars = catalog.Cars.OrderBy(car => car.Brand).ToList();
                Console.WriteLine("Cars:");
                foreach (Car car in catalog.Cars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }                    
            }
            if (catalog.Trucks.Count > 0)
            {
                catalog.Trucks = catalog.Trucks.OrderBy(truck => truck.Brand).ToList();
                Console.WriteLine("Trucks:");
                foreach (Truck truck in catalog.Trucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }                    
            }
        }
    }
    class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }
    class Catalog
    {
        public Catalog()
        {
            Trucks = new List<Truck>();
            Cars = new List<Car>();
        }
        public List<Truck> Trucks { get; set; }
        public List<Car> Cars { get; set; }
    }
}