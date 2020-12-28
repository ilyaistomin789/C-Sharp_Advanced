using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB_1.Abstract_Factory
{
    public class Warrior
    {
        private Weapon _weapon;
        private Armour _armour;

        public Warrior(WarriorFactory factory)
        {
            _weapon = factory.CreateWeapon();
            _armour = factory.CreateArmour();
            GetArmourInfo();
            GetWeaponInfo();
        }

        public WarriorFactory WarriorFactory
        {
            get => default;
            set
            {
            }
        }

        public Armour Armour
        {
            get => default;
            set
            {
            }
        }

        public Weapon Weapon
        {
            get => default;
            set
            {
            }
        }

        public void GetArmourInfo()
        {
            _armour.Characteristic();
        }

        public void GetWeaponInfo()
        {
            _weapon.Characteristic();
        }
    }
}
