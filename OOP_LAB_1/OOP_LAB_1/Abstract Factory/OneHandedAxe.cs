using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB_1.Abstract_Factory
{
    public class OneHandedAxe : Weapon
    {
        private static Random _damage = new Random();
        public override int Damage => _damage.Next(300);
        public override void Characteristic()
        {
            Console.WriteLine($"\nName : One Handed Axe \nDamage : +{Damage} \nWeight : 6 kg");
        }
    }
}
