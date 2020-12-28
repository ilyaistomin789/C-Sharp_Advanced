using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB_1.Singleton
{
    public class President
    {
        private static President _instancePresident;

        private President()
        {
            Console.WriteLine("President Singleton");
        }

        public static President GetInstance()
        {
            if (_instancePresident==null)
                _instancePresident = new President();
            return _instancePresident;
        }
    }
}
