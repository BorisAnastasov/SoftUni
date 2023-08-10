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
                switch (info[0])
                {
                    case "Citizen":
                        Citizen citizen = new(info[1], int.Parse(info[2]), info[3], info[4]);
                        if (citizen.BirthDate.EndsWith(key))
                        {
                            denied.Add(citizen.BirthDate);
                        }
                        break;
                    case "Robot":
                        Robot robot = new Robot(info[1], info[2]);
                        break;
                    case "Pet":
                        Pet pet = new( info[1], info[2]);
                        if (pet.BirthDate.EndsWith(key))
                        {
                            denied.Add(pet.BirthDate);
                        }
                        break;
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine,denied));
        }
    }
}