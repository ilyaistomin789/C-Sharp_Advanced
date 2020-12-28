using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB_2.Decorator
{
    public class Books : Decorator
    {
        void PutInBag()
        {
            Console.WriteLine("The SchoolBoy put the books in bag");
        }

        public override void GoToSchool()
        {
            base.GoToSchool();
            PutInBag();
        }
    }
}
