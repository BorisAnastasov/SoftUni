namespace T04.PizzaCalories
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double pizzaCalories = 0;
                string[] pizzaInfo = Console.ReadLine().Split(" ").ToArray();
                string pizzaName = pizzaInfo[1];
                string[] doughInfo = Console.ReadLine().Split(" ").ToArray();
                string flourType = doughInfo[1];
                string Baking = doughInfo[2];
                int grams = int.Parse(doughInfo[3]);
                Dough dough = new(flourType, Baking, grams);
                pizzaCalories += dough.Sum();
                Pizza pizza = new(pizzaName, dough);                
                string[] toppingInfo = Console.ReadLine().Split(" ").ToArray();
                while (toppingInfo[0] != "END")
                {
                    string topp = toppingInfo[1];
                    int toppingGrams = int.Parse(toppingInfo[2]);
                    Topping topping = new(topp, toppingGrams);
                    pizzaCalories += topping.Sum();
                    pizza.AddTopping(topping);
                    toppingInfo = Console.ReadLine().Split(" ").ToArray();
                }
                Console.WriteLine($"{pizza.Name} - {pizzaCalories:f2} Calories.");
            }
            catch (Exception ex )
            {
                Console.WriteLine(ex.Message);
                return;
            }            
        }
    }
}