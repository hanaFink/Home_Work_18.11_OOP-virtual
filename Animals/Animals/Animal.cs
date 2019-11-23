using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public abstract class Animal
    {
        string _name;

        public Animal(string name)
        {
            _name = name;
        }

        public abstract void MakeSound();

        public override string ToString()
        {
            return $"This is {_name }";
        }
    }
}

