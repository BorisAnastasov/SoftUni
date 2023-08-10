﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Car
    {
        public Car(string model, int weight, string color, Engine engine)
        {
            Model = model;
            Weight = weight;
            Color = color;
            Engine = engine;
        }

        public string Model { get; set; }
        public int Weight { get; set; }
        public string Color { get; set; }
        public Engine Engine { get; set; }

    }
}
