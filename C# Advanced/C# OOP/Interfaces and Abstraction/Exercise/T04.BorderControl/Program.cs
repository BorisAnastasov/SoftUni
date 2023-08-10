namespace T04.BorderControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> denied = new();
            List<string> data = new();
            string input = Console.ReadLine();
            while (input!="End")
            {
                data.Add(input);

                input = Console.ReadLine();
            }
            string key=Console.ReadLine();

            foreach (var item in data)
            {
                string[] info = item.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (info.Length == 2)
                {
                    Robot robot = new Robot(info[0], info[1]);
                    if (robot.Id.EndsWith(key))
                    {
                        denied.Add(robot.Id);
                    }
                }
                else if (info.Length == 3)
                {
                    Citizen citizen = new(info[0], int.Parse(info[1]), info[2]);
                    if(citizen.Id.EndsWith(key)) 
                    { 
                        denied.Add(citizen.Id);
                    }

                }
            }
            Console.WriteLine(string.Join(Environment.NewLine,denied));
        }
    }
}