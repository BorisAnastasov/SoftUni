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
                int engineSpeed = int.Parse(arr[1]);
                int enginePower = int.Parse(arr[2]);
                int cargoWeight = int.Parse(arr[3]);
                string cargoType = arr[4];
                double tire1Pressure = double.Parse(arr[5]);
                int tire1Age = int.Parse(arr[6]);
                double tire2Pressure = double.Parse(arr[7]);
                int tire2Age = int.Parse(arr[8]);
                double tire3Pressure = double.Parse(arr[9]);
                int tire3Age = int.Parse(arr[10]);
                double tire4Pressure = double.Parse(arr[11]);
                int tire4Age = int.Parse(arr[12]);
                Car car = new(model,engineSpeed,enginePower,cargoType,cargoWeight,
                    tire1Age,tire1Pressure,tire2Age,tire2Pressure,tire3Age,tire3Pressure
                    ,tire4Age,tire4Pressure); 
                list.Add(car);
            }
            string input = Console.ReadLine();
            if(input== "fragile")
            {
                foreach (var item in list)
                {
                    if (item.Tyres.Any(x => x.Pressure < 1))
                    {
                        Console.WriteLine(item.Model);
                    }
                }
            }
            else if(input == "flammable")
            {
                foreach (var item in list)
                {
                    if (item.Engine.Power > 250)
                    {
                        Console.WriteLine(item.Model);
                    }
                }
            }
        }
    }
}