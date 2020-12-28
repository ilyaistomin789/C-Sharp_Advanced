using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB_1.Builder
{
    public class Director
    {
        private Builder builder;

        public Director(Builder builder)
        {
            this.builder = builder;
        }

        public void Launch()
        {
            builder.AddManager();
            builder.AddSenior();
            builder.AddMiddle();
            builder.AddJun();
        }

        public void CustomLaunch(params object[] obj)
        {
            foreach (var elements in obj)
            {
                if (elements == typeof(JuniorDev))
                {
                    builder.AddJun();   
                }
                if (elements == typeof(Manager))
                {
                    builder.AddManager();
                }
                if (elements == typeof(SeniorDev))
                {
                    builder.AddSenior();
                }
                if (elements == typeof(MiddleDev))
                {
                    builder.AddMiddle();
                }
            }
        }

    }
}
