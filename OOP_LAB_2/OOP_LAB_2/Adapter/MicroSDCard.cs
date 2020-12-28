using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB_2.Adapter
{
    public class MicroSDCard : ICards
    {
        public void Insert()
        {
            Console.WriteLine("Inserted Micro-SD Card");
        }

        public void GetResult()
        {
            Console.WriteLine("Files from Micro-SD Card were transferred successful");
        }
    }
}
