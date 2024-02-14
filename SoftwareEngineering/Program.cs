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
            SEStudent s1 = new SEStudent("Malenia, Blade of Miquella", "Java");
            SEStudent s2 = new SEStudent("Aldrich, Devourer of Gods", "HolyC");
            SEStudent s3 = new SEStudent("Godrick The Grafted", "C++");

            Department<SEStudent> department = new Department<SEStudent>("From Software", "Naotoshi Zin");

            department.EnrollStudent(s1);
            department.EnrollStudent(s2);
            department.EnrollStudent(s3);

            Console.WriteLine(department.ToString());

            department.ExpelStudent(s3);
            Console.WriteLine("Отчисление 1 студента\n");
            Console.WriteLine(department.ToString());

        }

        public override string ToString()
        {
            return FIO + ". Знает " + ProgrammingLanguage;
        }
    }
}
