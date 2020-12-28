using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB_2.Decorator
{
    public class Bag : Decorator
    {
        private string bagInfo = "The school boy took the bag";
        public override void GoToSchool()
        {
            base.GoToSchool();
            Console.WriteLine(bagInfo);
        }
    }
}
