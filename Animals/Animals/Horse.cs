using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Horse:Animal
    {
        bool _rasingHorse;
        public Horse(string name, bool rasingHorse) : base(name)
        {
            _rasingHorse = rasingHorse;
        }

        public virtual void Neigh()
        {
            Console.WriteLine("Igogo");
        }
        public override void MakeSound()
        {
            this.Neigh();
        }
        public bool IsRaising()
        {
            return _rasingHorse;
        }

    }
}
