using System.Reflection;

namespace DefiningClasses
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            List<Car> list = new();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] arr = Console.ReadLine().Split(" ").ToArray();
                string model = arr[0];
                double fuelAmount = double.Parse(arr[1]);
                double fuelConsumption = double.Parse(arr[2]);
                Car car = new(model, fuelAmount, fuelConsumption,0);
                list.Add(car);
            }
            string[] input = Console.ReadLine().Split(" ").ToArray();
            while (input[0] != "End")
            {
                string model = input[1];    
                double km = double.Parse(input[2]);
                Car.Drive(list,model,km);

                input = Console.ReadLine().Split(" ").ToArray();
            }
            foreach (var item in list)
            {
                Console.WriteLine($"{item.Model} {item.FuelAmount:f2} {item.TravelledDistance}");
            }
        }
    }
}