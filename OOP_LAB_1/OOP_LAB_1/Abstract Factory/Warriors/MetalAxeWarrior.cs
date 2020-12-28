using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB_1.Abstract_Factory.Warriors
{
    public class MetalAxeWarrior : WarriorFactory
    {
        public override Weapon CreateWeapon()
        {
            return new OneHandedAxe();
        }

        public override Armour CreateArmour()
        {
            return new MetalArmour();
        }
    }
}
