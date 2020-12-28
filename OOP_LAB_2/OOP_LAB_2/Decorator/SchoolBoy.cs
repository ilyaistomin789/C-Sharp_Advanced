using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB_2.Decorator
{
    public class SchoolBoy : School
    {
        public override void GoToSchool()
        {
            Console.WriteLine("Student went to school");
        }
    }
}
