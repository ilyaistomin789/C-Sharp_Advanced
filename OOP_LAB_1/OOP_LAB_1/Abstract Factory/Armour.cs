using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OOP_LAB_1.Abstract_Factory
{
    public abstract class Armour
    {
        public abstract int Protection { get; }
        public abstract void Characteristic();
    }
}
