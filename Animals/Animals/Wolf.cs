using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Wolf:Dog
    {
        string _nameOfPack;

        public Wolf(string name, string favoriteDogFood, string nameOfPack): base (name, favoriteDogFood)
        {
            _nameOfPack = nameOfPack;
        }

        public override string ToString()
        {
            return base.ToString()+$" name of pack is {_nameOfPack}";
        }


    }
}
