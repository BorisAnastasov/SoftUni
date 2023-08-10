using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T04.Wild_Farm.Models.Interfaces;

namespace T04.Wild_Farm.Models
{
    public class Owl : Bird
    {
        public Owl(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {
        }
        public override string Sound()
        {
            return "Hoot Hoot";
        }
    }
}
