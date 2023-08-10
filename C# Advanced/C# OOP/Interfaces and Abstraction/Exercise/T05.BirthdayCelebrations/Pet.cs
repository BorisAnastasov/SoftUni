using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T04.BorderControl
{
    public class Pet:IBirthdate
    {
        private string name;
        private string birthdate;

        public Pet(string name, string birthdate)
        {
            Name = name;
            BirthDate = birthdate;
        }

        public string Name { get; set; }
        public string BirthDate { get; set; }
    }
}
