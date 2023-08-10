using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T04.Wild_Farm.Models.Interfaces;

namespace T04.Wild_Farm.Models
{
    public class Seeds : Food
    {
        public Seeds(int quantity) : base(quantity)
        {
        }
    }
}
