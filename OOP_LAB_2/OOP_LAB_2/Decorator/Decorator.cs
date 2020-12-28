using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB_2.Decorator
{
    public abstract class Decorator : School
    {
        public School School { protected get; set; }
        public override void GoToSchool()
        {
            School?.GoToSchool();
        }
    }
}
