using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB_1.Abstract_Factory.Warriors
{
    public class ChainMailKnifeWarrior : WarriorFactory
    {
        public override Weapon CreateWeapon()
        {
            return new Knife();
        }

        public override Armour CreateArmour()
        {
            return new ChainMailArmour();
        }
    }
}
