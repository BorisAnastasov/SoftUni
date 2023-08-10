namespace T9._Pokemon_Trainer
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            List<Trainer> trainers = new List<Trainer>();
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            while (input[0] != "Tournament")
            {
                string trainerName = input[0];
                string pokemonName = input[1];
                string pokemonElement = input[2];
                int pokemonHealth = int.Parse(input[3]);
                bool nm = false;
                Trainer trainer;
                foreach (var item in trainers)
                {
                    if(item.Name== trainerName)
                    {
                        Pokemon pokemon = new(pokemonName, pokemonElement, pokemonHealth);
                        trainer = item;
                        trainers.Remove(item);
                        trainer.Pokemons.Add(pokemon);
                        trainers.Add(trainer);
                        nm = true;
                        break;
                    }
                }
                if(!nm) 
                {
                    trainer = new(trainerName);
                    trainer.Pokemons = new List<Pokemon>();
                    trainer.Badgets = 0;
                    Pokemon pokemon = new(pokemonName, pokemonElement, pokemonHealth);
                    trainer.Pokemons.Add(pokemon);
                    trainers.Add(trainer);
                }                                                                               
                input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
            string cmd = Console.ReadLine();
            while (cmd != "End")
            {
                Checking(cmd, trainers);

                cmd = Console.ReadLine();
            }
            foreach (var item in trainers.OrderByDescending(x=>x.Badgets))
            {
                Console.WriteLine($"{item.Name} {item.Badgets} {item.Pokemons.Count}");
            }
        }
        public static void Checking(string elem, List<Trainer> trainers)
        {
            bool el = true;
            foreach (var trainer in trainers)
            {
                foreach (var item in trainer.Pokemons)
                {
                    if (item.Element == elem)
                    {
                        trainer.Badgets++;
                        el = false;
                        break;
                    }

                }
                if (el)
                {
                    for (int i = 0; i < trainer.Pokemons.Count; i++)
                    {
                        trainer.Pokemons[i].Health -= 10;
                        if (trainer.Pokemons[i].Health <= 0)
                        {
                            trainer.Pokemons.RemoveAt(i);
                            i--;
                        }
                    }

                }
                el = false;
            }
        }
    }
}