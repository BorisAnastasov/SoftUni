namespace T01.Vehicles
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] carInfo = Console.ReadLine().Split(" ").ToArray();
            Car car = new(double.Parse(carInfo[1]), double.Parse(carInfo[2]));
            string[] truckInfo = Console.ReadLine().Split(" ").ToArray();
            Truck truck = new(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]));
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split(" ").ToArray();
                string cmd = info[0];
                string vehicle = info[1];
                double num = double.Parse(info[2]);
                if (cmd == "Drive") 
                {
                    if (vehicle == "Car")
                    {
                        car.Drive(num);
                    }
                    else if (vehicle == "Truck")
                    {
                        truck.Drive(num);
                    }
                }
                else if (cmd == "Refuel")
                {
                    if (vehicle == "Car")
                    {
                        car.Refuel(num);

                    }
                    else if (vehicle == "Truck")
                    {
                        truck.Refuel(num);
                    }
                }
            }
            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
        }
    }
}