using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB_2.Adapter
{
    public class SDCard : ICards
    {
        public void Insert()
        {
            Console.WriteLine("Inserted SD Card");
        }

        public void GetResult()
        {
            Console.WriteLine("Files from SD Card were transferred successful");
        }
    }
}
