using System.Security.Cryptography.X509Certificates;
using T04.BorderControl;

namespace T06.FoodShortage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Citizen> citizens= new List<Citizen>();
            List<Rebel> rebels= new List<Rebel>();  
            for (int i = 0; i < n; i++)
            {
                string[] r = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (r.Length == 4)
                {
                    Citizen citizen = new(r[0], int.Parse(r[1]), r[2], r[3]);
                    citizens.Add(citizen);
                }
                else if (r.Length == 3)
                {
                    Rebel citizen = new(r[0], int.Parse(r[1]), r[2]);
                    rebels.Add(citizen);
                }
            }
            string data = Console.ReadLine();
            while (data != "End")
            {
                if(citizens.FirstOrDefault(x => x.Name == data)!=null)
                {
                    Citizen citizen = citizens.FirstOrDefault(x => x.Name == data);
                    foreach (var item in citizens)
                    {
                        if (item == citizen)
                        {
                            item.BuyFood();
                        }
                    }
                }
                else if(rebels.FirstOrDefault(x => x.Name == data) != null)
                {
                    Rebel rebel = rebels.FirstOrDefault(x => x.Name == data);
                    foreach (var item in rebels)
                    {
                        if (item == rebel)
                        {
                            item.BuyFood();
                        }
                    }
                }
                data = Console.ReadLine();
            }
            int sum = 0;
            foreach (var item in rebels) 
            {
                sum += item.Food;            
            }
            foreach (var item in citizens)
            {
                sum += item.Food;
            }
            Console.WriteLine(sum);
        }
    }
}