using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB_1.Builder
{
    public class ItCompany
    {
        readonly List<object> _organization = new List<object>();

        public void CreateItCompany(object obj)
        {
            _organization.Add(obj);
        }
    }
}
