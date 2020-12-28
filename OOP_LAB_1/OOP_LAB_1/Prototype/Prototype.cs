using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB_1.Prototype
{
    public class Prototype
    {
        public string Item { get; set; }
        public string Property { get; set; }

        public Prototype Clone()
        {
            return this.MemberwiseClone() as Prototype;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Element : ITEM : {Item} PROPERTY :  {Property}");
        }
    }
}
