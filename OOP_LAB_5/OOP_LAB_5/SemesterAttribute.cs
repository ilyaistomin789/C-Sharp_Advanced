using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB_5
{
    public class SemesterAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value != null)
            {
                int semesterValue = Int32.Parse((string)value);
                if (semesterValue > 0 && semesterValue < 9)
                {
                    return true;
                }
                else
                {
                    this.ErrorMessage = "Semester value is incorrect!!! Please, check this!";
                }

            }

            return false;
        }
    }
}
