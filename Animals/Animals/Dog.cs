using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Dog:Animal
    {
        string _favoriteDogFoog;

        public Dog(string name, string favoriteDogFoog): base (name)
        {
            _favoriteDogFoog = favoriteDogFoog;
        }

        public virtual void Bark()
        {
            Console.WriteLine("Vav-vav");
        }

        public override void MakeSound()
        {
            this.Bark();
        }

        public override string ToString()
        {
            return base.ToString()+ $" and it's favorite food is { _favoriteDogFoog} ";
        }
    }
}
