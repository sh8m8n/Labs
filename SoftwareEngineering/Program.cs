using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentRegister;

namespace SoftwareEngineering
{
    public class SEStudent
    {
        public string FIO { get; set; }

        public string ProgrammingLanguage { get; set; }

        public SEStudent(string fio, string programmingLanguage) 
        {
            FIO = fio;
            ProgrammingLanguage = programmingLanguage;
        }

        static void Main()
        {
            SEStudent s = new SEStudent("fuck", "holyC");

            Department<SEStudent> department = new Department<SEStudent>("from software", "Naotoshi Zin");

            department.EnrollStudent(s);
            department.ExpelStudent(s);

        }

        public override string ToString()
        {
            return FIO + ". Знает " + ProgrammingLanguage;
        }
    }
}
