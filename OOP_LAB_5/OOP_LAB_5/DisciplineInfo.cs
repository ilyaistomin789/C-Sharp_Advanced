using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB_5
{
    public class DisciplineInfo
    {
        [Required(ErrorMessage = "Enter the Discipline Name",AllowEmptyStrings = false)]
        public string DisciplineName { get; set; }
        [Semester]
        public int Semester { get; set; }
        public List<int> Course { get; set; }
        public string Specialization { get; set; }
        [Required(ErrorMessage =  "Enter the Lectures Number", AllowEmptyStrings = false)]
        [Range(1,80)]
        public int LecturesNumber { get; set; }
        [Required(ErrorMessage = "Enter the Lectures Labs", AllowEmptyStrings = false)]
        [Range(1,20)]
        public int LabsNumber { get; set; }
        public string TypeOfControl { get; set; }
        public string DepartmentLector { get; set; }
        [Required(ErrorMessage = "Enter the FIO of Lector", AllowEmptyStrings = false)]
        public string FioLector { get; set; }
        public string AuditoriumLector { get; set; }

            

        public override string ToString()
        {
            string result = $"Discipline name : {DisciplineName} \nSemester : {Semester} \nCourse : ";
            foreach (var element in Course)
            {
                result += $"{element} ";
            }

            result +=
                $"\nSpecialization : {Specialization} \nLectures number : {LecturesNumber} \nLabs Number : {LabsNumber} \nType of control : {TypeOfControl} \nDepartment of Lector : {DepartmentLector} \nFIO of Lector : {FioLector} \nAuditorium for Lector : {AuditoriumLector}\n\n";
            return result;
        }
    }
}
