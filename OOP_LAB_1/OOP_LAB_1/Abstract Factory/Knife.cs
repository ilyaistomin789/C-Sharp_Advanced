using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB_1.Abstract_Factory
{
    class Knife : Weapon
    {
        private static Random _damage = new Random();
        public override int Damage => _damage.Next(100);
        public override void Characteristic()
        {
            Console.WriteLine($"\nName : Knife \nDamage : +{Damage} \nWeight : 2 kg");
        }
    }
}
