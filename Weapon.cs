using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battlefield
{
    class Weapon
    {
        public string name;
        public double attackLevel;

        public Weapon(string name, double attackLevel)
        {
            this.name = name;
            this.attackLevel = attackLevel;
        }
    }
}
