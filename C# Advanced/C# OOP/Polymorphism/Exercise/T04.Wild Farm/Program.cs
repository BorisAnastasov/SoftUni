using System.Xml.Linq;
using T04.Wild_Farm.Models;
using T04.Wild_Farm.Models.Interfaces;

namespace T04.Wild_Farm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            List<Food> foods = new List<Food>();
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] animalInfo = input.Split(" ").ToArray();
                //animal
                switch (animalInfo[0])
                {
                    case "Hen":
                        Hen hen = new(animalInfo[1], double.Parse(animalInfo[2]), double.Parse(animalInfo[3]));
                        animals.Add(hen);
                        break;
                    case "Owl":
                        Owl owl = new(animalInfo[1], double.Parse(animalInfo[2]), double.Parse(animalInfo[3]));
                        animals.Add(owl);
                        break;
                    case "Mouse":
                        Mouse mouse = new(animalInfo[1], double.Parse(animalInfo[2]), animalInfo[3]);
                        animals.Add(mouse);
                        break;
                    case "Cat":
                        Cat cat = new(animalInfo[1], double.Parse(animalInfo[2]), animalInfo[3], animalInfo[4]);
                        animals.Add(cat);
                        break;
                    case "Dog":
                        Dog dog = new(animalInfo[1], double.Parse(animalInfo[2]), animalInfo[3]);
                        animals.Add(dog);
                        break;
                    case "Tiger":
                        Tiger tiger = new(animalInfo[1], double.Parse(animalInfo[2]), animalInfo[3], animalInfo[4]);
                        animals.Add(tiger);
                        break;
                }
                //food
                string[] foodInfo = Console.ReadLine().Split(" ").ToArray();
                int quantity = int.Parse(foodInfo[1]);
                switch (foodInfo[0])
                {
                    case "Vegetable":
                        Vegetable vegetable = new(quantity);
                        foods.Add(vegetable);
                        break;
                    case "Fruit":
                        Fruit fruit = new(quantity);
                        foods.Add(fruit);
                        break;
                    case "Meat":
                        Meat meat = new(quantity);
                        foods.Add(meat);
                        break;
                    case "Seeds":
                        Seeds seeds = new(quantity);
                        foods.Add(seeds);
                        break;
                }
            }
            for (int i = 0; i < animals.Count; i++)
            {
                string animalType = animals[i].GetType().Name;
                string foodType = foods[i].GetType().Name;
                Console.WriteLine(animals[i].Sound());
                if (animalType == "Hen")
                {
                    animals[i].Weight += 0.35 * foods[i].Quantity;
                    animals[i].FoodEaten += foods[i].Quantity;
                }
                else if (animalType == "Mouse")
                {
                    if (foodType == "Vegetable" || foodType == "Fruit")
                    {
                        animals[i].Weight += 0.1 * foods[i].Quantity;
                        animals[i].FoodEaten += foods[i].Quantity;
                    }
                    else
                    {
                        Console.WriteLine($"{animalType} does not eat {foodType}!");
                    }
                }
                else if (animalType == "Cat")
                {
                    if (foodType == "Vegetable" || foodType == "Meat")
                    {
                        animals[i].Weight += 0.3 * foods[i].Quantity;
                        animals[i].FoodEaten += foods[i].Quantity;
                    }
                    else
                    {
                        Console.WriteLine($"{animalType} does not eat {foodType}!");
                    }
                }
                else
                {
                    if (foodType == "Meat")
                    {
                        if (animalType == "Owl")
                        {
                            animals[i].Weight += 0.25 * foods[i].Quantity;

                        }
                        else if (animalType == "Dog")
                        {
                            animals[i].Weight += 0.4 * foods[i].Quantity;

                        }
                        else//Tiger
                        {
                            animals[i].Weight += 1 * foods[i].Quantity;

                        }
                        animals[i].FoodEaten += foods[i].Quantity;
                    }
                    else
                    {
                        Console.WriteLine($"{animalType} does not eat {foodType}!");
                    }

                }
            }
            foreach (var item in animals)
            {

                Console.WriteLine(item.ToString());
            }
        }
    }
}