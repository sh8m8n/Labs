using StudentRegister;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalInstitute
{
    public class MedicalStudent
    {
        public string Name { get; set; }
        public string Specialization { get; set; }

        public MedicalStudent(string name, string specialization)
        {
            Name = name;
            Specialization = specialization;
        }

        static void Main()
        {
            //Инициализация студентов и отделения
            MedicalStudent s1 = new MedicalStudent("Шэдоухарт", "Домен жизни");
            MedicalStudent s2 = new MedicalStudent("Mercy", "Bodybuilding");
            MedicalStudent s3 = new MedicalStudent("Фома", "Стрельба из лука");

            Department<MedicalStudent> department = new Department<MedicalStudent>("From Software", "Naotoshi Zin");

            //Зачисление студентов
            department.EnrollStudent(s1);
            department.EnrollStudent(s2);
            department.EnrollStudent(s3);

            Console.WriteLine(department.ToString());

            //Отчисление студентов
            department.EnrollStudent(s1);

            Console.WriteLine("Отчисление 1 студента\n");
            Console.WriteLine(department.ToString());
        }

        public override string ToString()
        {
            return Name + " " + Specialization;
        }
    }
}
