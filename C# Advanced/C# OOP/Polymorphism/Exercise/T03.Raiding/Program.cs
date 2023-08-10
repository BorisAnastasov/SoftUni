using T03.Raiding.Models;
using static System.Formats.Asn1.AsnWriter;

namespace T03.Raiding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<BaseHero> list = new List<BaseHero>();
            while (n != 0)
            {
                string name = Console.ReadLine();
                string type = Console.ReadLine();
                switch (type)
                {
                    case "Druid":
                        Druid druid = new(name);
                        list.Add(druid);
                        n--;
                        break;
                    case "Paladin":
                        Paladin paladin = new(name);
                        list.Add(paladin);
                        n--;
                        break;
                    case "Rogue":
                        Rogue rogue = new(name);
                        list.Add(rogue);
                        n--;
                        break;
                    case "Warrior":
                        Warrior warrior = new(name);
                        list.Add(warrior);
                        n--;
                        break;
                    default: Console.WriteLine("Invalid hero!"); break;
                }
            }
            int monster = int.Parse(Console.ReadLine());
            foreach (var item in list)
            {
                Console.WriteLine(item.CastAbility());
                monster -= item.Power;
            }
            if (monster > 0)
            {
                Console.WriteLine("Defeat...");
            }
            else
            {
                Console.WriteLine("Victory!");
            }
        }
    }
}