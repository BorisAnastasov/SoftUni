﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Engine
    {
        public Engine(int speed, int power) 
        { 
            Speed = speed;
            Power = power;
        }


        public int Speed { get; set; }
        public int Power { get; set; }
    }
}
