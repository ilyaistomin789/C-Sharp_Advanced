using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB_1.Abstract_Factory
{
    public abstract class Weapon
    {
        public abstract int Damage { get; }
        public abstract void Characteristic();
    }
}
