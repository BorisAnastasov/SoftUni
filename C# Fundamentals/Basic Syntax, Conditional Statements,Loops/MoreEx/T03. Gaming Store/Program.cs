using System;

namespace T03._Gaming_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());
            string game = Console.ReadLine();
            double totalSpent = 0;
            bool h = true;
            while (game != "Game Time")
            {
                double decrease = 0;
                switch (game)
                {
                    case "OutFall 4":
                        decrease = 39.99;
                        break;
                    case "CS: OG":
                        decrease = 15.99;
                        break;
                    case "Zplinter Zell":
                        decrease = 19.99;
                        break;
                    case "Honored 2":
                        decrease = 59.99;
                        break;
                    case "RoverWatch":
                        decrease = 29.99;
                        break;
                    case "RoverWatch Origins Edition":
                        decrease = 39.99;
                        break;
                        default:
                        Console.WriteLine("Not Found");
                        h = false;
                        break;
                }
                if (h)
                {
                    if (balance - decrease < 0)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else if (balance - decrease == 0)
                    {
                        Console.WriteLine($"Bought {game}");
                        Console.WriteLine("Out of money!");
                        return;
                    }
                    else
                    {
                        totalSpent += decrease;
                        balance -= decrease;
                        Console.WriteLine($"Bought {game}");
                    }
                }
                h = true;
                game = Console.ReadLine();
            }
            Console.WriteLine($"Total spent: ${totalSpent:f2}. Remaining: ${balance:f2}");
        }
    }
}
