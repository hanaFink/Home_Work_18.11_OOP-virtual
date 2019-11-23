using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Poodle:Dog
    {
        string _numberOfPonyTails;

        public Poodle(string name, string favoriteDogFood ,string numberOfPonyTails): base (name, favoriteDogFood)
        {

            _numberOfPonyTails = numberOfPonyTails;
        }
        public override void Bark()
        {
            Console.WriteLine("Wi -wi");
        }
        public override string ToString()
        {
            return base.ToString() + $" and number of Pony tails is {_numberOfPonyTails} ";
        }
    }
}
