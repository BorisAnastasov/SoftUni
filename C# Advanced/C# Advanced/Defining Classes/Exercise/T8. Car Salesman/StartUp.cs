using System.Text;

namespace DefiningClasses
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string model = input[0];
                int power = int.Parse(input[1]);
                int displacement = 0;
                string efficiency = "n/a";
                if (input.Length== 3) 
                {
                    string elem = input[2];
                    if(int.TryParse(elem, out  displacement))
                    {

                    }
                    else
                    {
                        efficiency = elem;                        
                    }                                       
                }
                else if(input.Length == 4)
                {
                   displacement = int.Parse(input[2]);
                   efficiency = input[3];
                }
                Engine engine = new Engine(model, power, displacement, efficiency);
                
                engines.Add(engine);
            }
            int m = int.Parse(Console.ReadLine());
            Engine engine1 = new Engine();
            string[] input1;
            for (int i = 0; i < m; i++)
            {
                input1 = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();
                string model = input1[0];
                string engineName = input1[1];
                
                foreach (var item in engines)
                {
                    if(item.Model== engineName)
                    {
                        engine1 = item;
                    }
                }
                int weight = 0;
                string color = "n/a";
                if (input1.Length == 3)
                {
                    string elem = input1[2];
                    if (int.TryParse(elem, out weight))
                    {

                    }
                    else
                    {
                        color = elem;
                    }
                }
                else if (input1.Length == 4)
                {
                    weight = int.Parse(input1[2]);
                    color = input1[3];
                }
                Car car = new Car(model, weight, color, engine1);
                cars.Add(car);
            }
            Print(cars);
        }
        public static void Print(List<Car> cars)
        {
            foreach (var car in cars)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"{car.Model}:");
                sb.AppendLine($"  {car.Engine.Model }:");
                sb.AppendLine($"    Power: {car.Engine.Power}");
                if (car.Engine.Displacement == 0)
                {
                    sb.AppendLine($"    Displacement: n/a");
                }
                else
                {
                    sb.AppendLine($"    Displacement: {car.Engine.Displacement}");
                }
                sb.AppendLine($"    Efficiency: {car.Engine.Efficiency}");
                if (car.Weight == 0)
                {
                    sb.AppendLine($"  Weight: n/a");
                }
                else
                {
                    sb.AppendLine($"  Weight: {car.Weight}");
                }                
                sb.Append($"  Color: {car.Color}");
                Console.WriteLine(sb);
            }

        }
    }
}