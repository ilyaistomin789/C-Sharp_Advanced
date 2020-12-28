using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB_1.Builder
{
    class ConcreteBuilder : Builder
    {
        ItCompany itCompany = new ItCompany();

        public ItCompany ItCompany
        {
            get => default;
            set
            {
            }
        }

        public override void AddManager()
        {
            itCompany.CreateItCompany(new Manager());
        }

        public override void AddJun()
        {
            itCompany.CreateItCompany(new JuniorDev());
        }

        public override void AddSenior()
        {
            itCompany.CreateItCompany(new SeniorDev());
        }

        public override void AddMiddle()
        {
            itCompany.CreateItCompany(new MiddleDev());
        }

        public override ItCompany GetResult()
        {
            return itCompany;
        }
    }
}
