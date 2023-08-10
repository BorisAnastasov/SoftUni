using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T04.Wild_Farm.Models.Interfaces;

namespace T04.Wild_Farm.Models
{
    public class Tiger : Feline
    {
        public Tiger(string name, double weight, string livingRegion, string breed) : base(name, weight,livingRegion, breed)
        {
        }
        public override string Sound()
        {
            return "ROAR!!!";
        }
    }
}
