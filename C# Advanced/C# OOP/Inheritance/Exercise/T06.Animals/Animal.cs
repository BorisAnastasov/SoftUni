﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public abstract class Animal
    {
        private string name;
        private int age;
        private string gender;
        public Animal(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value)) { throw new ArgumentException("Invalid input!"); }
                name = value;
            }
        }
        public int Age
        {
            get => age;
            
            set
            {
                if (value<=0)
                {
                    throw new ArgumentException("Invalid input!");

                }
                age = value;
            }
        }
        public string Gender 
        {
            get => gender;
            private set
            {
                if (string.IsNullOrWhiteSpace(value)) { throw new ArgumentException("Invalid input!"); }
                gender = value;
            }
        }
        public override string ToString() => $"{Name} {Age} {Gender}{Environment.NewLine}{ProduceSound()}";

        public abstract string ProduceSound();
    }
}
