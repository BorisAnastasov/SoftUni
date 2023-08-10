using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T9._Pokemon_Trainer
{
    public class Trainer
    {
        public string Name { get; set; }
        public int Badgets { get; set; }
        public List<Pokemon> Pokemons { get; set; }
        public Trainer(string name) 
        { 
          Name= name;        
        }
        public Trainer(string name, List<Pokemon> pokemons)
        {
            Name = name;
            Pokemons = pokemons;

        }
    }
}
