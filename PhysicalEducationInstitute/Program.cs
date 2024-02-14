using StudentRegister;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysicalEducationInstitute
{
    public class PEStudent
    {
        public string FIO { get; set; }
        public string SportDiscipline { get; set; }

        public PEStudent(string fio, string sportDiscipline)
        {
            FIO = fio;
            SportDiscipline = sportDiscipline;
        }

        static void Main()
        {
            //Инициализация студентов и отделения
            PEStudent s1 = new PEStudent("Владимир Владимирович", "дзюдо");
            PEStudent s2 = new PEStudent("Billy Herrington", "Bodybuilding");
            PEStudent s3 = new PEStudent("Фома", "Стрельба из лука");

            Department<PEStudent> department = new Department<PEStudent>("Спортивный институт", "...");

            //Зачисление студентов
            department.EnrollStudent(s1);
            department.EnrollStudent(s2);
            department.EnrollStudent(s3);

            Console.WriteLine(department.ToString());

            //Отчисление студентов
            department.EnrollStudent(s2);

            Console.WriteLine("Отчисление 1 студента\n");
            Console.WriteLine(department.ToString());
        }

        public override string ToString()
        {
            return FIO + " " + SportDiscipline;
        }
    }
}
